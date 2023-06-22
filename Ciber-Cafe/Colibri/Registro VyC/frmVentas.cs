using Colibri.Dtos;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Colibri.Registro_VyC
{
    public partial class frmVentas : Form
    {
        public static int ventaId = 0;
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            GetAllVentas();
        }
        private async void GetAllVentas()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7253/api/Ventas"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ventas = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<List<VentaDto>>(ventas);
                        dgvVentas.DataSource = result.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de ventas: {response.StatusCode}");
                    }
                }
            }
        }
        private void Clear()
        {
            txtTypeCompro.Text = string.Empty;
            txtNameEmployee.Text = string.Empty;
            txtSComprobante.Text = string.Empty;
            txtNameClien.Text = string.Empty;
            txtIdVentas.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtIdVentas.Focus();
            ventaId = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Valida() == "si")
            {
                AddVenta();
            }
            else
            {
                MessageBox.Show("El error se encuentra en " + Valida(), "ERROR DE ESPACIOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void AddVenta()
        {
            VentaCreateDto ventaCreateDto = new VentaCreateDto();
            ventaCreateDto.TipoComprobante = txtTypeCompro.Text;
            ventaCreateDto.ClienteId = int.Parse(txtNameClien.Text);
            ventaCreateDto.SerieComprobante = txtSComprobante.Text;
            ventaCreateDto.EmpleadoId = int.Parse(txtNameEmployee.Text);
            ventaCreateDto.Fecha = DateTime.Parse(dtpDate.Text);
            ventaCreateDto.Total = decimal.Parse(txtTotal.Text);
            using (var client = new HttpClient())
            {
                var serializeProduct = JsonConvert.SerializeObject(ventaCreateDto);
                var content = new StringContent(serializeProduct, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7253/api/Ventas", content);

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Venta agregada");
                else
                    MessageBox.Show($"Error al guardar la venta: {response.Content.ReadAsStringAsync().Result}");
            }
            Clear();
            GetAllVentas();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Valida() == "si")
            {
                if (ventaId != 0)
                    UpdateVenta();
            }
            else
            {
                MessageBox.Show("El error se encuentra en " + Valida(), "ERROR DE ESPACIOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UpdateVenta()
        {
            VentaUpdateDto ventaUpdateDto = new VentaUpdateDto();
            ventaUpdateDto.VentasId = int.Parse(txtIdVentas.Text);
            ventaUpdateDto.TipoComprobante = txtTypeCompro.Text;
            ventaUpdateDto.ClienteId = int.Parse(txtNameEmployee.Text);
            ventaUpdateDto.SerieComprobante = txtSComprobante.Text;
            ventaUpdateDto.EmpleadoId = int.Parse(txtNameClien.Text);
            ventaUpdateDto.Fecha = DateTime.Parse(dtpDate.Text);
            ventaUpdateDto.Total = decimal.Parse(txtTotal.Text);

            using (var client = new HttpClient())
            {
                var student = JsonConvert.SerializeObject(ventaUpdateDto);
                var content = new StringContent(student, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Ventas", ventaId), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Venta actualizada");
                else
                    MessageBox.Show($"Error al actualizar la venta: {response.StatusCode}");
            }
            Clear();
            GetAllVentas();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ventaId != 0)
                DeleteVenta();
        }
        private async void DeleteVenta()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7253/api/Ventas");
                var response = await client.DeleteAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Ventas", ventaId));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Venta eliminada");
                else
                    MessageBox.Show($"No se pudo eliminar la venta: {response.StatusCode}");
            }
            Clear();
            GetAllVentas();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private async void GetCompraById()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Ventas", ventaId));
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    VentaDto ventaDto = JsonConvert.DeserializeObject<VentaDto>(data);
                    txtTypeCompro.Text = ventaDto.TipoComprobante;
                    txtNameEmployee.Text = ventaDto.ClienteId.ToString();
                    txtSComprobante.Text = ventaDto.SerieComprobante;
                    txtNameClien.Text = ventaDto.EmpleadoId.ToString();
                    dtpDate.Text = ventaDto.Fecha.ToString();
                    txtTotal.Text = ventaDto.Total.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la venta: {response.StatusCode}");
                }
            }
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    ventaId = int.Parse(row.Cells[0].Value.ToString());
                    GetCompraById();
                }
            }
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

                string PaginaHTML_Texto = Properties.Resources.Plantilla_Ventas.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Empleado", txtNameEmployee.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", txtSComprobante.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", dtpDate.ToString());

                string filas = string.Empty;
                decimal total = 0;

                foreach (DataGridViewRow row in dgvVentas.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["ID"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Cliente"].Value.ToString() + "</td>";
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
            catch (Exception ex)
            {

                MessageBox.Show($"Erorr{ex.Message}");
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
            if (txtTypeCompro.Text.Trim().Length == 0)
            {
                txtTypeCompro.Clear();
                txtTypeCompro.Focus();
                return "Tipo Comprobante";
            }
            else if (txtNameClien.Text.Trim().Length == 0)
            {
                txtNameClien.Clear();
                txtNameClien.Focus();
                return "Nombre del Cliente";
            }
            else if (txtSComprobante.Text.Trim().Length == 0)
            {
                txtSComprobante.Clear();
                txtSComprobante.Focus();
                return "Serie Comprobante";
            }
            else if (txtNameEmployee.Text.Trim().Length == 0)
            {
                txtNameEmployee.Clear();
                txtNameEmployee.Focus();
                return "Nombre del Empleado";
            }
            else if (txtIdVentas.Text.Trim().Length == 0)
            {
                txtIdVentas.Clear();
                txtIdVentas.Focus();
                return "Id de Venta";
            }
            else if (txtTotal.Text.Trim().Length == 0)
            {
                txtTotal.Clear();
                txtTotal.Focus();
                return "Total";
            }
            return "si";
        }
        #endregion
    }
}
