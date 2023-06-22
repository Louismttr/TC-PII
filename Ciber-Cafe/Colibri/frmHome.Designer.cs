namespace Colibri
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            p_Buttons = new Panel();
            btnMax = new PictureBox();
            btnClose = new PictureBox();
            pictureBox1 = new PictureBox();
            lblHora = new Label();
            lblFecha = new Label();
            HourDate_Timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            p_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // p_Buttons
            // 
            p_Buttons.Controls.Add(btnMax);
            p_Buttons.Controls.Add(btnClose);
            p_Buttons.Dock = DockStyle.Top;
            p_Buttons.Location = new Point(0, 0);
            p_Buttons.Name = "p_Buttons";
            p_Buttons.Size = new Size(800, 51);
            p_Buttons.TabIndex = 0;
            p_Buttons.MouseDown += p_Buttons_MouseDown;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Right;
            btnMax.Cursor = Cursors.Hand;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(701, 3);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(45, 45);
            btnMax.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMax.TabIndex = 5;
            btnMax.TabStop = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(752, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 45);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(284, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.Location = new Point(533, 435);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(90, 37);
            lblHora.TabIndex = 2;
            lblHora.Text = "label1";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.FromArgb(218, 182, 127);
            lblFecha.Location = new Point(591, 495);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(43, 17);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "label2";
            // 
            // HourDate_Timer
            // 
            HourDate_Timer.Enabled = true;
            HourDate_Timer.Tick += HourDate_Timer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(352, 285);
            label1.Name = "label1";
            label1.Size = new Size(133, 78);
            label1.TabIndex = 4;
            label1.Text = "Cibercafé\r\nColibrí";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 43);
            ClientSize = new Size(800, 540);
            Controls.Add(label1);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(pictureBox1);
            Controls.Add(p_Buttons);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(200, 146, 64);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHome";
            Text = "frmHome";
            MouseDown += frmHome_MouseDown;
            p_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel p_Buttons;
        private PictureBox btnClose;
        private PictureBox pictureBox1;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer HourDate_Timer;
        private Label label1;
        private PictureBox btnMax;
    }
}