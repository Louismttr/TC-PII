namespace Colibri
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            pButtons = new Panel();
            btn_Menu = new PictureBox();
            label1 = new Label();
            btnMin = new PictureBox();
            btnMax = new PictureBox();
            pLogo = new PictureBox();
            btnExit = new PictureBox();
            p_Menu = new Panel();
            panel6 = new Panel();
            btnClose = new Button();
            p_SubMenuReportes = new Panel();
            btnCompras = new Button();
            btnVentas = new Button();
            panel4 = new Panel();
            btnReport = new Button();
            panel3 = new Panel();
            btnPayments = new Button();
            p_SubMenuRegistrar = new Panel();
            btnAddProvedor = new Button();
            btnAddCliente = new Button();
            btnAddProdcut = new Button();
            panel2 = new Panel();
            btnAdd = new Button();
            panel1 = new Panel();
            btnHome = new Button();
            panel7 = new Panel();
            btnAddEmploye = new Button();
            p_SubMenuNomina = new Panel();
            pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Menu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            p_Menu.SuspendLayout();
            panel6.SuspendLayout();
            p_SubMenuReportes.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            p_SubMenuRegistrar.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            p_SubMenuNomina.SuspendLayout();
            SuspendLayout();
            // 
            // pButtons
            // 
            pButtons.BackColor = Color.FromArgb(0, 39, 53);
            pButtons.Controls.Add(btn_Menu);
            pButtons.Controls.Add(label1);
            pButtons.Controls.Add(btnMin);
            pButtons.Controls.Add(btnMax);
            pButtons.Controls.Add(pLogo);
            pButtons.Controls.Add(btnExit);
            pButtons.Dock = DockStyle.Top;
            pButtons.Location = new Point(0, 0);
            pButtons.Name = "pButtons";
            pButtons.Size = new Size(938, 60);
            pButtons.TabIndex = 1;
            pButtons.MouseDown += pButtons_MouseDown;
            // 
            // btn_Menu
            // 
            btn_Menu.Cursor = Cursors.Hand;
            btn_Menu.Image = (Image)resources.GetObject("btn_Menu.Image");
            btn_Menu.Location = new Point(12, 7);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(45, 45);
            btn_Menu.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Menu.TabIndex = 6;
            btn_Menu.TabStop = false;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 10);
            label1.Name = "label1";
            label1.Size = new Size(116, 40);
            label1.TabIndex = 5;
            label1.Text = "Colibri";
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Right;
            btnMin.Cursor = Cursors.Hand;
            btnMin.Image = (Image)resources.GetObject("btnMin.Image");
            btnMin.Location = new Point(788, 7);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(45, 45);
            btnMin.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMin.TabIndex = 3;
            btnMin.TabStop = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Right;
            btnMax.Cursor = Cursors.Hand;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(839, 7);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(45, 45);
            btnMax.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMax.TabIndex = 4;
            btnMax.TabStop = false;
            btnMax.Click += btnMax_Click;
            // 
            // pLogo
            // 
            pLogo.Image = (Image)resources.GetObject("pLogo.Image");
            pLogo.Location = new Point(119, 3);
            pLogo.Name = "pLogo";
            pLogo.Size = new Size(65, 55);
            pLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pLogo.TabIndex = 2;
            pLogo.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(890, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(45, 45);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 2;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // p_Menu
            // 
            p_Menu.AutoScroll = true;
            p_Menu.Controls.Add(panel6);
            p_Menu.Controls.Add(p_SubMenuReportes);
            p_Menu.Controls.Add(panel4);
            p_Menu.Controls.Add(p_SubMenuNomina);
            p_Menu.Controls.Add(panel3);
            p_Menu.Controls.Add(p_SubMenuRegistrar);
            p_Menu.Controls.Add(panel2);
            p_Menu.Controls.Add(panel1);
            p_Menu.Dock = DockStyle.Left;
            p_Menu.Location = new Point(0, 60);
            p_Menu.Name = "p_Menu";
            p_Menu.Size = new Size(190, 678);
            p_Menu.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnClose);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 553);
            panel6.Name = "panel6";
            panel6.Size = new Size(190, 69);
            panel6.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(0, 39, 53);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Top;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(145, 215, 184);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(145, 215, 184);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 215, 184);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(0, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(190, 66);
            btnClose.TabIndex = 8;
            btnClose.Text = "Cerrar\r\nSección\r\n";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // p_SubMenuReportes
            // 
            p_SubMenuReportes.Controls.Add(btnCompras);
            p_SubMenuReportes.Controls.Add(btnVentas);
            p_SubMenuReportes.Dock = DockStyle.Top;
            p_SubMenuReportes.Location = new Point(0, 450);
            p_SubMenuReportes.Name = "p_SubMenuReportes";
            p_SubMenuReportes.Size = new Size(190, 103);
            p_SubMenuReportes.TabIndex = 6;
            p_SubMenuReportes.Visible = false;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.FromArgb(39, 66, 81);
            btnCompras.Cursor = Cursors.Hand;
            btnCompras.Dock = DockStyle.Top;
            btnCompras.FlatAppearance.BorderColor = Color.FromArgb(145, 215, 184);
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatAppearance.MouseDownBackColor = Color.FromArgb(145, 215, 184);
            btnCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 215, 184);
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompras.ForeColor = Color.White;
            btnCompras.Image = (Image)resources.GetObject("btnCompras.Image");
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(0, 50);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(190, 50);
            btnCompras.TabIndex = 6;
            btnCompras.Text = "Compras";
            btnCompras.TextAlign = ContentAlignment.MiddleRight;
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(39, 66, 81);
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderColor = Color.FromArgb(145, 215, 184);
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(145, 215, 184);
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 215, 184);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.White;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 0);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(190, 50);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleRight;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnReport);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 400);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 50);
            panel4.TabIndex = 5;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(0, 39, 53);
            btnReport.Cursor = Cursors.Hand;
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderColor = Color.FromArgb(145, 215, 184);
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(145, 215, 184);
            btnReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 215, 184);
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReport.ForeColor = Color.White;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 0);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(190, 50);
            btnReport.TabIndex = 7;
            btnReport.Text = "Reportes\r\nContables\r\n";
            btnReport.TextAlign = ContentAlignment.MiddleRight;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPayments);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 253);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 54);
            panel3.TabIndex = 3;
            // 
            // btnPayments
            // 
            btnPayments.BackColor = Color.FromArgb(0, 39, 53);
            btnPayments.Cursor = Cursors.Hand;
            btnPayments.Dock = DockStyle.Top;
            btnPayments.FlatAppearance.BorderColor = Color.FromArgb(145, 215, 184);
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatAppearance.MouseDownBackColor = Color.FromArgb(145, 215, 184);
            btnPayments.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 215, 184);
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPayments.ForeColor = Color.White;
            btnPayments.Image = (Image)resources.GetObject("btnPayments.Image");
            btnPayments.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayments.Location = new Point(0, 0);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(190, 53);
            btnPayments.TabIndex = 4;
            btnPayments.Text = "Empleados";
            btnPayments.TextAlign = ContentAlignment.MiddleRight;
            btnPayments.UseVisualStyleBackColor = false;
            btnPayments.Click += btnPayments_Click;
            // 
            // p_SubMenuRegistrar
            // 
            p_SubMenuRegistrar.Controls.Add(btnAddProvedor);
            p_SubMenuRegistrar.Controls.Add(btnAddCliente);
            p_SubMenuRegistrar.Controls.Add(btnAddProdcut);
            p_SubMenuRegistrar.Dock = DockStyle.Top;
            p_SubMenuRegistrar.Location = new Point(0, 100);
            p_SubMenuRegistrar.Name = "p_SubMenuRegistrar";
            p_SubMenuRegistrar.Size = new Size(190, 153);
            p_SubMenuRegistrar.TabIndex = 2;
            p_SubMenuRegistrar.Visible = false;
            // 
            // btnAddProvedor
            // 
            btnAddProvedor.BackColor = Color.FromArgb(39, 66, 81);
            btnAddProvedor.Cursor = Cursors.Hand;
            btnAddProvedor.Dock = DockStyle.Top;
            btnAddProvedor.FlatAppearance.BorderColor = Color.FromArgb(145, 215, 184);
            btnAddProvedor.FlatAppearance.BorderSize = 0;
            btnAddProvedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(145, 215, 184);
            btnAddProvedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 215, 184);
            btnAddProvedor.FlatStyle = FlatStyle.Flat;
            btnAddProvedor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProvedor.ForeColor = Color.White;
            btnAddProvedor.Image = (Image)resources.GetObject("btnAddProvedor.Image");
            btnAddProvedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddProvedor.Location = new Point(0, 100);
            btnAddProvedor.Name = "btnAddProvedor";
            btnAddProvedor.Size = new Size(190, 50);
            btnAddProvedor.TabIndex = 7;
            btnAddProvedor.Text = "Agregar\r\nProveedores";
            btnAddProvedor.TextAlign = ContentAlignment.MiddleRight;
            btnAddProvedor.UseVisualStyleBackColor = false;
            btnAddProvedor.Click += btnAddProvedor_Click;
            // 
            // btnAddCliente
            // 
            btnAddCliente.BackColor = Color.FromArgb(39, 66, 81);
            btnAddCliente.Cursor = Cursors.Hand;
            btnAddCliente.Dock = DockStyle.Top;
            btnAddCliente.FlatAppearance.BorderColor = Color.FromArgb(145, 215, 184);
            btnAddCliente.FlatAppearance.BorderSize = 0;
            btnAddCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(145, 215, 184);
            btnAddCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 215, 184);
            btnAddCliente.FlatStyle = FlatStyle.Flat;
            btnAddCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCliente.ForeColor = Color.White;
            btnAddCliente.Image = (Image)resources.GetObject("btnAddCliente.Image");
            btnAddCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddCliente.Location = new Point(0, 50);
            btnAddCliente.Name = "btnAddCliente";
            btnAddCliente.Size = new Size(190, 50);
            btnAddCliente.TabIndex = 5;
            btnAddCliente.Text = "Agregar\r\nCliente\r\n";
            btnAddCliente.TextAlign = ContentAlignment.MiddleRight;
            btnAddCliente.UseVisualStyleBackColor = false;
            btnAddCliente.Click += btnAddCliente_Click;
            // 
            // btnAddProdcut
            // 
            btnAddProdcut.BackColor = Color.FromArgb(39, 66, 81);
            btnAddProdcut.Cursor = Cursors.Hand;
            btnAddProdcut.Dock = DockStyle.Top;
            btnAddProdcut.FlatAppearance.BorderColor = Color.FromArgb(145, 215, 184);
            btnAddProdcut.FlatAppearance.BorderSize = 0;
            btnAddProdcut.FlatAppearance.MouseDownBackColor = Color.FromArgb(145, 215, 184);
            btnAddProdcut.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 215, 184);
            btnAddProdcut.FlatStyle = FlatStyle.Flat;
            btnAddProdcut.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProdcut.ForeColor = Color.White;
            btnAddProdcut.Image = (Image)resources.GetObject("btnAddProdcut.Image");
            btnAddProdcut.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddProdcut.Location = new Point(0, 0);
            btnAddProdcut.Name = "btnAddProdcut";
            btnAddProdcut.Size = new Size(190, 50);
            btnAddProdcut.TabIndex = 6;
            btnAddProdcut.Text = "Agregar\r\nProductos";
            btnAddProdcut.TextAlign = ContentAlignment.MiddleRight;
            btnAddProdcut.UseVisualStyleBackColor = false;
            btnAddProdcut.Click += btnAddProdcut_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 50);
            panel2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 39, 53);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Dock = DockStyle.Top;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(145, 215, 184);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(145, 215, 184);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 215, 184);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(190, 55);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Registrar";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 50);
            panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(0, 39, 53);
            btnHome.Cursor = Cursors.Hand;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(145, 215, 184);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(145, 215, 184);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 215, 184);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(190, 55);
            btnHome.TabIndex = 3;
            btnHome.Text = "Inicio";
            btnHome.TextAlign = ContentAlignment.MiddleRight;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(190, 60);
            panel7.Name = "panel7";
            panel7.Size = new Size(748, 678);
            panel7.TabIndex = 5;
            // 
            // btnAddEmploye
            // 
            btnAddEmploye.BackColor = Color.FromArgb(39, 66, 81);
            btnAddEmploye.Cursor = Cursors.Hand;
            btnAddEmploye.Dock = DockStyle.Top;
            btnAddEmploye.FlatAppearance.BorderColor = Color.FromArgb(145, 215, 184);
            btnAddEmploye.FlatAppearance.BorderSize = 0;
            btnAddEmploye.FlatAppearance.MouseDownBackColor = Color.FromArgb(145, 215, 184);
            btnAddEmploye.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 215, 184);
            btnAddEmploye.FlatStyle = FlatStyle.Flat;
            btnAddEmploye.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddEmploye.ForeColor = Color.White;
            btnAddEmploye.Image = (Image)resources.GetObject("btnAddEmploye.Image");
            btnAddEmploye.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddEmploye.Location = new Point(0, 0);
            btnAddEmploye.Name = "btnAddEmploye";
            btnAddEmploye.Size = new Size(190, 50);
            btnAddEmploye.TabIndex = 5;
            btnAddEmploye.Text = "Agregar\r\nEmpleado";
            btnAddEmploye.TextAlign = ContentAlignment.MiddleRight;
            btnAddEmploye.UseVisualStyleBackColor = false;
            btnAddEmploye.Click += btnAddEmploye_Click;
            // 
            // p_SubMenuNomina
            // 
            p_SubMenuNomina.Controls.Add(btnAddEmploye);
            p_SubMenuNomina.Dock = DockStyle.Top;
            p_SubMenuNomina.Location = new Point(0, 307);
            p_SubMenuNomina.Name = "p_SubMenuNomina";
            p_SubMenuNomina.Size = new Size(190, 93);
            p_SubMenuNomina.TabIndex = 4;
            p_SubMenuNomina.Visible = false;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 43);
            ClientSize = new Size(938, 738);
            Controls.Add(panel7);
            Controls.Add(p_Menu);
            Controls.Add(pButtons);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(200, 146, 64);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenu";
            Text = "frmMenu";
            pButtons.ResumeLayout(false);
            pButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Menu).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            p_Menu.ResumeLayout(false);
            panel6.ResumeLayout(false);
            p_SubMenuReportes.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            p_SubMenuRegistrar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            p_SubMenuNomina.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pButtons;
        private PictureBox btnMin;
        private PictureBox btnMax;
        private PictureBox pLogo;
        private PictureBox btnExit;
        private Label label1;
        private PictureBox btn_Menu;
        private Panel p_Menu;
        private Panel panel6;
        private Button btnClose;
        private Panel p_SubMenuReportes;
        private Button btnCompras;
        private Button btnVentas;
        private Panel panel4;
        private Button btnReport;
        private Panel panel3;
        private Button btnPayments;
        private Panel p_SubMenuRegistrar;
        private Button btnAddProvedor;
        private Button btnAddCliente;
        private Button btnAddProdcut;
        private Panel panel2;
        private Button btnAdd;
        private Panel panel1;
        private Button btnHome;
        private Panel panel7;
        private Panel p_SubMenuNomina;
        private Button btnAddEmploye;
    }
}