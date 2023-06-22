using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colibri
{
    public partial class frmPayrollSystem : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
        public frmPayrollSystem()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPayrollSystem_Load(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtBonoTransporte.Enabled = false;

            GetAllPayroll();
        }

        private void GetAllPayroll()
        {
            SqlConnection cn = new SqlConnection(connectionString);
            string query = "Select * from Nominas";
            SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvPS.DataSource = dt;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdEmp.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtAdelantoSueldo.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtBonoTransporte.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtHorasExtras.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtPagoHE.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtSalarioB.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else
            {
                decimal totalAsignaciones, seguroMed, totalDesucciones, sueldoBruto, sueldoNeto;
                int horasExt, precioHorasExt, pagoHorasExt, bonoTransp, adelantoSueldo;

                horasExt = Convert.ToInt32(txtHorasExtras.Text);
                precioHorasExt = Convert.ToInt32(txtPagoHE.Text);
                pagoHorasExt = horasExt * precioHorasExt;

                bonoTransp = Convert.ToInt32(txtBonoTransporte.Text);
                totalAsignaciones = pagoHorasExt + bonoTransp;

                sueldoBruto = decimal.Parse(txtSalarioB.Text);
                seguroMed = sueldoBruto * 0.0625m;

                adelantoSueldo = Convert.ToInt32(txtAdelantoSueldo.Text);
                totalDesucciones = seguroMed + adelantoSueldo;
                sueldoNeto = (sueldoBruto + totalAsignaciones) - totalDesucciones;

                txtPagoHE.Text = pagoHorasExt.ToString();
                txtTAsignaciones.Text = totalAsignaciones.ToString();
                txtSeguroMedico.Text = seguroMed.ToString();
                txtTDeducciones.Text = totalDesucciones.ToString();
                txtSueldoNeto.Text = sueldoNeto.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT EmpleadoId FROM Employees WHERE EmpleadoId=@Origin;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNombre.Text = reader["NombresEmpleado"].ToString();
                        txtApellido.Text = reader["ApellidosEmpleados"].ToString();
                        txtBonoTransporte.Text = reader["Salario"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No Existe empleado para realizar Nomina");
                    }
                    btnBuscar.Enabled = false;
                    txtIdEmp.Enabled = false;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se puede realizar la operacion por: {ex.Message}");
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnGuardar.Enabled = true;
            txtIdEmp.Enabled = true;
            txtIdEmp.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtSalarioB.Clear();
            txtHorasExtras.Clear();
            txtPrecioHora.Clear();
            txtPagoHE.Clear();
            txtBonoTransporte.Clear();
            txtTAsignaciones.Clear();
            txtSeguroMedico.Clear();
            txtAdelantoSueldo.Clear();
            txtTDeducciones.Clear();
            txtSueldoNeto.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe completar todos los campos!!!");
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtAdelantoSueldo.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtHorasExtras.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtPrecioHora.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtPagoHE.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtSeguroMedico.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtSalarioB.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtSueldoNeto.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtTAsignaciones.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else if (string.IsNullOrEmpty(txtTDeducciones.Text))
            {
                MessageBox.Show("Debe de llenar los campos!");
            }
            else
            {
                GuardarNomina();
                btnGuardar.Enabled = false;
            }
        }

        private void GuardarNomina()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SP_InsertarNomina", connection);
            SqlCommand cmd = new SqlCommand();
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, (30)).Value = txtNombre.Text;
            adapter.SelectCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, (30)).Value = txtApellido.Text;
            adapter.SelectCommand.Parameters.Add("@SueldoBruto", SqlDbType.VarChar, (50)).Value = txtSalarioB.Text;
            adapter.SelectCommand.Parameters.Add("@HorasExt", SqlDbType.Int).Value = txtHorasExtras.Text;
            adapter.SelectCommand.Parameters.Add("@PrecioHorasExt", SqlDbType.Int).Value = txtPrecioHora.Text;
            adapter.SelectCommand.Parameters.Add("@PagoHorasExt", SqlDbType.Int).Value = txtPagoHE.Text;
            adapter.SelectCommand.Parameters.Add("@BonoTransporte", SqlDbType.Int).Value = txtBonoTransporte.Text;
            adapter.SelectCommand.Parameters.Add("@SeguroMedico", SqlDbType.Float).Value = txtSeguroMedico.Text;
            adapter.SelectCommand.Parameters.Add("@AdelantoSueldo", SqlDbType.Int).Value = txtAdelantoSueldo.Text;
            adapter.SelectCommand.Parameters.Add("@SueldoNeto", SqlDbType.Float).Value = txtSueldoNeto.Text;

            adapter.SelectCommand.ExecuteNonQuery();

            MessageBox.Show("Nomina agregada con exito!");
            GetAllPayroll();
            connection.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }
    }
}
