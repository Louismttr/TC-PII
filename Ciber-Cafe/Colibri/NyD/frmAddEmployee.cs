using Colibri.Dtos;
using Newtonsoft.Json;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colibri.NyD
{
    public partial class frmAddEmployee : Form
    {
        private static int empleadoId = 0;
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (empleadoId != 0)
            {
                UpdateEmployee();
            }
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            GetAllEmployee();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (empleadoId != 0)
                DeleteEmployee();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    empleadoId = int.Parse(row.Cells[0].Value.ToString());
                    GetEmployeeById();
                }
            }
        }

        #region Metodos 
        private async void GetAllEmployee()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7253/api/Empleados"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var employee = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<List<EmpleadoDto>>(employee);
                        dgvEmployee.DataSource = result.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de empleados: {response.StatusCode}");
                    }
                }
            }
        }

        private async void AddEmployee()
        {
            EmpleadoCreateDto empleadoCreateDto = new EmpleadoCreateDto();
            empleadoCreateDto.RolId = int.Parse(txtIdRol.Text);
            empleadoCreateDto.NombresEmpleado = txtNombre.Text;
            empleadoCreateDto.ApellidosEmpleados = txtApellido.Text;
            empleadoCreateDto.DNI = txtDNI.Text;
            empleadoCreateDto.Contraseña = txtContra.Text;
            empleadoCreateDto.Telofono = int.Parse(txtTelefono.Text);
            empleadoCreateDto.Direccion = txtDireccion.Text;
            empleadoCreateDto.Salario = decimal.Parse(txtSalario.Text);

            using (var client = new HttpClient())
            {
                var serializeEmpleado = JsonConvert.SerializeObject(empleadoCreateDto);
                var content = new StringContent(serializeEmpleado, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7253/api/Empleados", content);

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Empleado agregado");
                else
                    MessageBox.Show($"Error al guardar el Empleado: {response.Content.ReadAsStringAsync().Result}");
            }
            Clear();
            GetAllEmployee();
        }

        private void Clear()
        {
            txtIdEmp.Focus(); txtIdEmp.Clear();
            txtIdRol.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtContra.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtSalario.Clear();
            empleadoId = 0;
        }
        private async void UpdateEmployee()
        {
            EmpleadoUpdateDto employeeUpdateDto = new EmpleadoUpdateDto();
            employeeUpdateDto.EmpleadoId = int.Parse(txtIdEmp.Text);
            employeeUpdateDto.RolId = int.Parse(txtIdRol.Text);
            employeeUpdateDto.NombresEmpleado = txtNombre.Text;
            employeeUpdateDto.ApellidosEmpleados = txtApellido.Text;
            employeeUpdateDto.DNI = txtDNI.Text;
            employeeUpdateDto.Contraseña = txtContra.Text;
            employeeUpdateDto.Telofono = int.Parse(txtTelefono.Text);
            employeeUpdateDto.Direccion = txtDireccion.Text;
            employeeUpdateDto.Salario = decimal.Parse(txtSalario.Text);
            using (var client = new HttpClient())
            {
                var employee = JsonConvert.SerializeObject(employeeUpdateDto);
                var content = new StringContent(employee, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Empleados", empleadoId), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Empleado actualizado");
                else
                    MessageBox.Show($"Error al actualizar el Empleado: {response.StatusCode}");
            }
            Clear();
            GetAllEmployee();
        }
        private async void DeleteEmployee()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7253/api/Empleados");
                var response = await client.DeleteAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Empleados", empleadoId));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Empleado eliminado");
                else
                    MessageBox.Show($"No se pudo eliminar el Empleado: {response.StatusCode}");
            }
            Clear();
            GetAllEmployee();
        }

        private async void GetEmployeeById()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Empleados", empleadoId));
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    EmpleadoDto empleadoDto = JsonConvert.DeserializeObject<EmpleadoDto>(data);
                    txtIdEmp.Text = empleadoDto.EmpleadoId.ToString();
                    txtIdRol.Text = empleadoDto.RolId.ToString();
                    txtNombre.Text = empleadoDto.NombresEmpleado;
                    txtApellido.Text = empleadoDto.ApellidosEmpleados;
                    txtDNI.Text = empleadoDto.DNI;
                    txtContra.Text = empleadoDto.Contraseña;
                    txtTelefono.Text = empleadoDto.Telofono.ToString();
                    txtDireccion.Text = empleadoDto.Direccion;
                    txtSalario.Text = empleadoDto.Salario.ToString();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener al Empleado: {response.StatusCode}");
                }
            }
        }
        #endregion



        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdEmp.Focus(); txtIdEmp.Clear();
            txtIdRol.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtContra.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtSalario.Clear();
        }
    }
}
