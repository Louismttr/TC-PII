using CiberCafeColibriAPI.Models;
using Colibri.Dtos;
using Newtonsoft.Json;
using System;
using System.Text;

using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace Colibri.Registro_VyC
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }
        private static int compraId = 0;

        private async void GetAllCompras()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7253/api/Compras"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var compras = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<List<CompraDto>>(compras);
                        dgvCompras.DataSource = result.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de compras: {response.StatusCode}");
                    }
                }
            }
        }
        private void Clear()
        {
            txtTyptCom.Focus();
            txtIdEmployee.Clear();
            txtID.Clear();
            txtRasson.Clear();
            compraId = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Valida() == "si")
            {
                AddCompra();
            }
            else
            {
                MessageBox.Show("El error se encuentra en " + Valida(), "ERROR DE ESPACIOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void AddCompra()
        {
            CompraCreateDto compraCreateDto = new CompraCreateDto();
            compraCreateDto.SereiComprobante = txtTyptCom.Text;
            compraCreateDto.ProveedorId = int.Parse(txtID.Text);
            compraCreateDto.Total = decimal.Parse(txtRasson.Text);
            using (var client = new HttpClient())
            {
                var serializeProduct = JsonConvert.SerializeObject(compraCreateDto);
                var content = new StringContent(serializeProduct, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7253/api/Compras", content);

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Compra agregada");
                else
                    MessageBox.Show($"Error al guardar la compra: {response.Content.ReadAsStringAsync().Result}");
            }
            Clear();
            GetAllCompras();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            GetAllCompras();
            TotalSuma();
        }
        public void TotalSuma()
        {
            const int columna = 3;
            int suma = 0;
            foreach (DataGridViewRow row in dgvCompras.Rows)
            {
                suma += (int)row.Cells[columna].Value;
            }
            lblTotal.Text = suma.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Valida() == "si")
            {
                if (compraId != 0)
                    UpdateCompra();
            }
            else
            {
                MessageBox.Show("El error se encuentra en " + Valida(), "ERROR DE ESPACIOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void UpdateCompra()
        {
            CompraUpdateDto compraUpdateDto = new CompraUpdateDto();
            compraUpdateDto.CompraId = compraId;
            compraUpdateDto.SereiComprobante = txtTyptCom.Text;
            compraUpdateDto.ProveedorId = int.Parse(txtID.Text);
            compraUpdateDto.Total = decimal.Parse(txtRasson.Text);

            using (var client = new HttpClient())
            {
                var student = JsonConvert.SerializeObject(compraUpdateDto);
                var content = new StringContent(student, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Compras", compraId), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Compra actualizada");
                else
                    MessageBox.Show($"Error al actualizar la compra: {response.StatusCode}");
            }
            Clear();
            GetAllCompras();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (compraId != 0)
                DeleteCompra();
        }
        private async void DeleteCompra()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7253/api/Compras");
                var response = await client.DeleteAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Compras", compraId));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Compra eliminada");
                else
                    MessageBox.Show($"No se pudo eliminar la compra: {response.StatusCode}");
            }
            Clear();
            GetAllCompras();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvCompras.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    compraId = int.Parse(row.Cells[0].Value.ToString());
                    GetCompraById();
                }
            }
        }

        private async void GetCompraById()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Compras", compraId));
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    CompraDto compraDto = JsonConvert.DeserializeObject<CompraDto>(data);
                    txtIdEmployee.Text = compraDto.CompraId.ToString();
                    txtID.Text = compraDto.ProveedorId.ToString();
                    txtTyptCom.Text = compraDto.SereiComprobante;
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la compra: {response.StatusCode}");
                }
            }
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.Plantillas_Compras.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Empleado", txtIdEmployee.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", txtTyptCom.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;

            foreach (DataGridViewRow row in dgvCompras.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Importe"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["Importe"].Value.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {

                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));


                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Logo, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }
        #region Valida
        private string Valida()
        {
            if(txtID.Text.Trim().Length == 0)
            {
                txtID.Clear();
                txtID.Focus();
                return "ID";
            }
            else if(txtIdEmployee.Text.Trim().Length == 0)
            {
                txtIdEmployee.Clear();
                txtIdEmployee.Focus();
                return "Id del Empleado";
            }
            else if(txtTyptCom.Text.Trim().Length == 0)
            {
                txtTyptCom.Clear();
                txtTyptCom.Focus();
                return "Tipo de Comprobante";
            }
            return "si";
        }
        #endregion
    }
}
