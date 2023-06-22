using Colibri.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Colibri.Registro_VyC
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        public static int proveedorId = 0;

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            GetAllProveedores();
        }

        private async void GetAllProveedores()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7253/api/Proveedores"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var proveedores = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<List<ProveedorDto>>(proveedores);
                        dataGridView1.DataSource = result.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de proveedores: {response.StatusCode}");
                    }
                }
            }
        }

        private void Clear()
        {
            textBox1.Clear(); textBox1.Focus();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear(); proveedorId = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProveedor();
        }

        private async void AddProveedor()
        {
            ProveedorCreateDto proveedorCreateDto = new ProveedorCreateDto();
            proveedorCreateDto.RazonSocial = textBox2.Text;
            proveedorCreateDto.RUC = textBox3.Text;
            proveedorCreateDto.Telefono = int.Parse(textBox4.Text);
            proveedorCreateDto.Direccion = textBox5.Text;
            using (var client = new HttpClient())
            {
                var serializeProveedor = JsonConvert.SerializeObject(proveedorCreateDto);
                var content = new StringContent(serializeProveedor, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7253/api/Proveedores", content);

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Proveedor agregado");
                else
                    MessageBox.Show($"Error al guardar el proveedor: {response.Content.ReadAsStringAsync().Result}");
            }
            Clear();
            GetAllProveedores();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (proveedorId != 0)
                UpdateProveedor();
        }
        private async void UpdateProveedor()
        {
            ProveedorUpdateDto proveedorUpdateDto = new ProveedorUpdateDto();
            proveedorUpdateDto.ProveedorId = int.Parse(textBox1.Text);
            proveedorUpdateDto.RazonSocial = textBox2.Text;
            proveedorUpdateDto.RUC = textBox3.Text;
            proveedorUpdateDto.Telefono = int.Parse(textBox4.Text);
            proveedorUpdateDto.Direccion = textBox5.Text;

            using (var client = new HttpClient())
            {
                var cosa = JsonConvert.SerializeObject(proveedorUpdateDto);
                var content = new StringContent(cosa, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Proveedores", proveedorId), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Proveedor actualizado");
                else
                    MessageBox.Show($"Error al actualizar el proveedor: {response.StatusCode}");
            }
            Clear();
            GetAllProveedores();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (proveedorId != 0)
                DeleteProveedor();
        }

        private async void DeleteProveedor()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7253/api/Proveedores");
                var response = await client.DeleteAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Proveedores", proveedorId));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Proveedor eliminado");
                else
                    MessageBox.Show($"No se pudo eliminar el proveedor: {response.StatusCode}");
            }
            Clear();
            GetAllProveedores();
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    proveedorId = int.Parse(row.Cells[0].Value.ToString());
                    GetProveedorById();
                }
            }
        }

        private async void GetProveedorById()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "url url url lru", proveedorId));
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    ProveedorDto clienteDto = JsonConvert.DeserializeObject<ProveedorDto>(data);
                    textBox2.Text = clienteDto.RazonSocial;
                    textBox3.Text = clienteDto.RUC;
                    textBox4.Text = clienteDto.Telefono.ToString();
                    textBox5.Text = clienteDto.Direccion;
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el proveedor: {response.StatusCode}");
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }
    }
}
