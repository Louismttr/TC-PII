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

namespace Colibri.Registro_VyC
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        public static int clienteId = 0;

        private void frmClientes_Load(object sender, EventArgs e)
        {
            GetAllClientes();
        }

        private async void GetAllClientes()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7253/api/Clientes"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var cliente = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<List<ClienteDto>>(cliente);
                        dataGridView1.DataSource = result.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de clientes: {response.StatusCode}");
                    }
                }
            }
        }

        private void Clear()
        {
            textBox1.Clear(); textBox1.Focus();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            clienteId = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Valida() == "si")
            {
                AddCliente();
            }
            else
            {
                MessageBox.Show("El error se encuentra en " + Valida(), "ERROR DE ESPACIOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void AddCliente()
        {
            ClienteCreateDto clienteCreateDto = new ClienteCreateDto();
            clienteCreateDto.NombresCliente = textBox2.Text;
            clienteCreateDto.ApellidosCliente = textBox3.Text;
            clienteCreateDto.RUC = textBox4.Text;
            clienteCreateDto.Telefono = int.Parse(textBox5.Text);
            clienteCreateDto.Direccion = textBox6.Text;
            using (var client = new HttpClient())
            {
                var serializeCliente = JsonConvert.SerializeObject(clienteCreateDto);
                var content = new StringContent(serializeCliente, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7253/api/Clientes", content);

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Cliente agregado");
                else
                    MessageBox.Show($"Error al guardar el cliente: {response.Content.ReadAsStringAsync().Result}");
            }
            Clear();
            GetAllClientes();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Valida() == "si")
            {
                if (clienteId != 0)
                    UpdateCliente();
            }
            else
            {
                MessageBox.Show("El error se encuentra en " + Valida(), "ERROR DE ESPACIOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void UpdateCliente()
        {
            ClienteUpdateDto clienteUpdateDto = new ClienteUpdateDto();
            clienteUpdateDto.ClienteId = int.Parse(textBox1.Text);
            clienteUpdateDto.NombresCliente = textBox2.Text;
            clienteUpdateDto.ApellidosCliente = textBox3.Text;
            clienteUpdateDto.RUC = textBox4.Text;
            clienteUpdateDto.Telefono = int.Parse(textBox5.Text);
            clienteUpdateDto.Direccion = textBox6.Text;

            using (var client = new HttpClient())
            {
                var cosa = JsonConvert.SerializeObject(clienteUpdateDto);
                var content = new StringContent(cosa, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Clientes", clienteId), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Cliente actualizado");
                else
                    MessageBox.Show($"Error al actualizar el cliente: {response.StatusCode}");
            }
            Clear();
            GetAllClientes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clienteId != 0)
                DeleteCliente();
        }

        private async void DeleteCliente()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7253/api/Clientes");
                var response = await client.DeleteAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Clientes", clienteId));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Cliente eliminado");
                else
                    MessageBox.Show($"No se pudo eliminar el cliente: {response.StatusCode}");
            }
            Clear();
            GetAllClientes();
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
                    clienteId = int.Parse(row.Cells[0].Value.ToString());
                    GetClienteById();
                }
            }
        }

        private async void GetClienteById()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Clientes", clienteId));
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    ClienteDto clienteDto = JsonConvert.DeserializeObject<ClienteDto>(data);
                    textBox1.Text = clienteDto.ClienteId.ToString();
                    textBox2.Text = clienteDto.NombresCliente;
                    textBox3.Text = clienteDto.ApellidosCliente;
                    textBox4.Text = clienteDto.RUC;
                    textBox5.Text = clienteDto.Telefono.ToString();
                    textBox6.Text = clienteDto.Direccion;
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el cliente: {response.StatusCode}");
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
        #region Valida
        private string Valida()
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                textBox1.Clear();
                textBox1.Focus();
                return "Id del Cliente";
            }
            else if (textBox2.Text.Trim().Length == 0)
            {
                textBox2.Clear();
                textBox2.Focus();
                return "Nombre";
            }
            else if (textBox3.Text.Trim().Length == 0)
            {
                textBox3.Clear();
                textBox3.Focus();
                return "Apellido";
            }
            else if (textBox4.Text.Trim().Length == 0)
            {
                textBox4.Clear();
                textBox4.Focus();
                return "RUC";
            }
            else if (textBox5.Text.Trim().Length == 0)
            {
                textBox5.Clear();
                textBox5.Focus();
                return "Teléfono";
            }
            else if (textBox6.Text.Trim().Length == 0)
            {
                textBox6.Clear();
                textBox6.Focus();
                return "Dirección";
            }
            return "si";
        }
        #endregion
    }
}
