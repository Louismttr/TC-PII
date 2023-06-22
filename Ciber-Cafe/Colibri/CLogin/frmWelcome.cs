using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colibri.CLogin
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbCarga.ForeColor = Color.FromArgb(0, 39, 53);
            if (this.Opacity < 1) this.Opacity += 0.05;
            pbCarga.Value += 1;
            if (pbCarga.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pbCarga.ForeColor = Color.FromArgb(0, 39, 53);
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            pbCarga.ForeColor = Color.FromArgb(0, 39, 53);
            this.Opacity -= 0.1;
            pbCarga.Value = 0;
            pbCarga.Minimum = 0;
            pbCarga.Maximum = 100;
            //Iniciamos el temporizador 1.
            timer1.Start();
        }
    }
}
