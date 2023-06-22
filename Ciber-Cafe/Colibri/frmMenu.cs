using Colibri.AddProducts;
using Colibri.CLogin;
using Colibri.NyD;
using Colibri.Registro_VyC;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Colibri
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        Panel p = new Panel();

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg,
        int wparam, int lparam);

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (p_Menu.Width == 250)
            {
                p_Menu.Width = 65;
            }
            else { p_Menu.Width = 250; }
        }
        #region Move
        private void p_Contain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pButtons_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void p_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Buttons
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void OpenPanel(object FrmSon)
        {
            if (this.panel7.Controls.Count > 0)
                this.panel7.Controls.RemoveAt(0);
            Form fh = (Form)FrmSon;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            p_Menu.Text = fh.Text;
            this.panel7.Controls.Add(fh);
            this.panel7.Tag = fh;
            fh.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenPanel(new frmHome());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(p_SubMenuNomina);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(p_SubMenuRegistrar);
        }

        private void MostrarSubMenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                OcultarSubMenu();
                Submenu.Visible = true;
            }
            else { Submenu.Visible = false; }
        }
        private void OcultarSubMenu()
        {
            if (p_SubMenuNomina.Visible == true)
                p_SubMenuNomina.Visible = false;

            if (p_SubMenuRegistrar.Visible == true)
                p_SubMenuRegistrar.Visible = false;

            if (p_SubMenuReportes.Visible == true)
                p_SubMenuReportes.Visible = false;
        }

        private void btnAddEmploye_Click(object sender, EventArgs e)
        {
            OpenPanel(new frmAddEmployee());
        }

        private void btnPayRoll_Click(object sender, EventArgs e)
        {
            //OpenPanel(new frmPayrollSystem());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro que desea salir?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                frmLogin frm = new frmLogin();

                frm.Show();

                this.Hide();

                this.Close();
            }
            
        }

        private void p_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            OpenPanel(new frmClientes());
        }

        private void btnAddProdcut_Click(object sender, EventArgs e)
        {
            OpenPanel(new frmProducts());
        }

        private void btnAddProvedor_Click(object sender, EventArgs e)
        {
            OpenPanel(new frmProveedores());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            OpenPanel(new frmVentas());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            OpenPanel(new frmCompras());
        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(p_SubMenuReportes);
        }
    }
}
