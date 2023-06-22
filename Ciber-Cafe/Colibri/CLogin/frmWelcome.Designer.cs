namespace Colibri.CLogin
{
    partial class frmWelcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            pButtons = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pbCarga = new ProgressBar();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pButtons
            // 
            pButtons.BackColor = Color.FromArgb(0, 39, 53);
            pButtons.Controls.Add(label1);
            pButtons.Controls.Add(pictureBox2);
            pButtons.Dock = DockStyle.Top;
            pButtons.Location = new Point(0, 0);
            pButtons.Name = "pButtons";
            pButtons.Size = new Size(811, 85);
            pButtons.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(200, 146, 64);
            label1.Location = new Point(122, 3);
            label1.Name = "label1";
            label1.Size = new Size(165, 80);
            label1.TabIndex = 7;
            label1.Text = "CiberCafé \r\nColibrí";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo;
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pbCarga
            // 
            pbCarga.ForeColor = Color.RosyBrown;
            pbCarga.Location = new Point(412, 349);
            pbCarga.Name = "pbCarga";
            pbCarga.Size = new Size(399, 22);
            pbCarga.Style = ProgressBarStyle.Marquee;
            pbCarga.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(522, 178);
            label3.Name = "label3";
            label3.Size = new Size(179, 37);
            label3.TabIndex = 5;
            label3.Text = "¡Bienvenido!";
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 43);
            ClientSize = new Size(811, 369);
            Controls.Add(label3);
            Controls.Add(pbCarga);
            Controls.Add(pictureBox1);
            Controls.Add(pButtons);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmWelcome";
            Load += frmWelcome_Load;
            pButtons.ResumeLayout(false);
            pButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pButtons;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private ProgressBar pbCarga;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}