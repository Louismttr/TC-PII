namespace Colibri.CLogin
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pButtons = new Panel();
            btnMini = new PictureBox();
            btnExit = new PictureBox();
            pMove = new Panel();
            picbLogo = new PictureBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnAccess = new Button();
            label1 = new Label();
            cbView = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            pMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbLogo).BeginInit();
            SuspendLayout();
            // 
            // pButtons
            // 
            pButtons.BackColor = Color.FromArgb(0, 39, 53);
            pButtons.Controls.Add(btnMini);
            pButtons.Controls.Add(btnExit);
            pButtons.Dock = DockStyle.Top;
            pButtons.Location = new Point(0, 0);
            pButtons.Name = "pButtons";
            pButtons.Size = new Size(800, 50);
            pButtons.TabIndex = 0;
            pButtons.MouseDown += pButtons_MouseDown;
            // 
            // btnMini
            // 
            btnMini.Cursor = Cursors.Hand;
            btnMini.Image = (Image)resources.GetObject("btnMini.Image");
            btnMini.Location = new Point(697, 2);
            btnMini.Name = "btnMini";
            btnMini.Size = new Size(45, 45);
            btnMini.TabIndex = 2;
            btnMini.TabStop = false;
            btnMini.Click += btnMini_Click;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(748, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(45, 45);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 1;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // pMove
            // 
            pMove.BackColor = Color.FromArgb(0, 39, 53);
            pMove.Controls.Add(picbLogo);
            pMove.Dock = DockStyle.Left;
            pMove.Location = new Point(0, 50);
            pMove.Name = "pMove";
            pMove.Size = new Size(200, 460);
            pMove.TabIndex = 1;
            pMove.MouseDown += pMove_MouseDown;
            // 
            // picbLogo
            // 
            picbLogo.Image = (Image)resources.GetObject("picbLogo.Image");
            picbLogo.Location = new Point(0, 92);
            picbLogo.Name = "picbLogo";
            picbLogo.Size = new Size(200, 196);
            picbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picbLogo.TabIndex = 0;
            picbLogo.TabStop = false;
            picbLogo.MouseDown += picbLogo_MouseDown;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(21, 35, 43);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.FromArgb(200, 146, 64);
            txtUser.Location = new Point(275, 188);
            txtUser.Name = "txtUser";
            txtUser.ShortcutsEnabled = false;
            txtUser.Size = new Size(445, 20);
            txtUser.TabIndex = 10;
            txtUser.Text = "Usuario";
            txtUser.Enter += txtUser_Enter;
            txtUser.KeyPress += txtUser_KeyPress;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(21, 35, 43);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(200, 146, 64);
            txtPassword.Location = new Point(275, 260);
            txtPassword.Name = "txtPassword";
            txtPassword.ShortcutsEnabled = false;
            txtPassword.Size = new Size(445, 20);
            txtPassword.TabIndex = 11;
            txtPassword.Text = "Contraseña";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.KeyPress += txtPassword_KeyPress;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnAccess
            // 
            btnAccess.BackColor = Color.FromArgb(56, 57, 62);
            btnAccess.FlatStyle = FlatStyle.Flat;
            btnAccess.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccess.ForeColor = Color.FromArgb(200, 146, 64);
            btnAccess.Location = new Point(275, 365);
            btnAccess.Name = "btnAccess";
            btnAccess.Size = new Size(445, 37);
            btnAccess.TabIndex = 4;
            btnAccess.Text = "Acceder";
            btnAccess.UseVisualStyleBackColor = false;
            btnAccess.Click += btnAccess_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(200, 146, 64);
            label1.Location = new Point(413, 70);
            label1.Name = "label1";
            label1.Size = new Size(178, 86);
            label1.TabIndex = 6;
            label1.Text = "CiberCafé \r\nColibrí";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbView
            // 
            cbView.AutoSize = true;
            cbView.ForeColor = Color.FromArgb(200, 146, 64);
            cbView.Location = new Point(646, 295);
            cbView.Name = "cbView";
            cbView.Size = new Size(74, 21);
            cbView.TabIndex = 8;
            cbView.Text = "Mostrar";
            cbView.UseVisualStyleBackColor = true;
            cbView.CheckedChanged += cbView_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(275, 216);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(445, 1);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Location = new Point(275, 288);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(445, 1);
            flowLayoutPanel2.TabIndex = 10;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 43);
            ClientSize = new Size(800, 510);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(cbView);
            Controls.Add(label1);
            Controls.Add(btnAccess);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(pMove);
            Controls.Add(pButtons);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "frmLogin";
            pButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            pMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pButtons;
        private PictureBox btnExit;
        private PictureBox btnMini;
        private Panel pMove;
        private PictureBox picbLogo;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnAccess;
        private Label label1;
        private CheckBox cbView;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}