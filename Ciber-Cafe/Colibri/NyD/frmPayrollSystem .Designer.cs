namespace Colibri
{
    partial class frmPayrollSystem
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayrollSystem));
            pButtons = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnClose = new PictureBox();
            dgvPS = new DataGridView();
            txtSueldoNeto = new TextBox();
            label17 = new Label();
            txtTDeducciones = new TextBox();
            txtAdelantoSueldo = new TextBox();
            txtSeguroMedico = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            txtTAsignaciones = new TextBox();
            label12 = new Label();
            label11 = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnCalcular = new Button();
            txtBonoTransporte = new TextBox();
            label10 = new Label();
            txtPrecioHora = new TextBox();
            label9 = new Label();
            txtHorasExtras = new TextBox();
            label8 = new Label();
            txtSalarioB = new TextBox();
            label7 = new Label();
            txtPagoHE = new TextBox();
            label6 = new Label();
            txtApellido = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtIdEmp = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            groupBox4 = new GroupBox();
            pictureBox3 = new PictureBox();
            groupBox3 = new GroupBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            btnMax = new PictureBox();
            pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPS).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            SuspendLayout();
            // 
            // pButtons
            // 
            pButtons.Controls.Add(btnMax);
            pButtons.Controls.Add(pictureBox1);
            pButtons.Controls.Add(label2);
            pButtons.Controls.Add(btnClose);
            pButtons.Dock = DockStyle.Top;
            pButtons.Location = new Point(0, 0);
            pButtons.Name = "pButtons";
            pButtons.Size = new Size(875, 50);
            pButtons.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 92;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(65, 9);
            label2.Name = "label2";
            label2.Size = new Size(266, 37);
            label2.TabIndex = 2;
            label2.Text = "Nomina Empleados";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(818, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 45);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvPS
            // 
            dgvPS.AllowUserToAddRows = false;
            dgvPS.AllowUserToDeleteRows = false;
            dgvPS.BackgroundColor = Color.FromArgb(21, 35, 43);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(21, 35, 43);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(150, 178, 196);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPS.Dock = DockStyle.Bottom;
            dgvPS.GridColor = Color.FromArgb(200, 146, 64);
            dgvPS.Location = new Point(0, 434);
            dgvPS.Name = "dgvPS";
            dgvPS.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(21, 35, 43);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(150, 178, 196);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvPS.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvPS.RowTemplate.Height = 25;
            dgvPS.Size = new Size(875, 216);
            dgvPS.TabIndex = 1;
            // 
            // txtSueldoNeto
            // 
            txtSueldoNeto.ForeColor = Color.FromArgb(200, 146, 64);
            txtSueldoNeto.Location = new Point(544, 60);
            txtSueldoNeto.Name = "txtSueldoNeto";
            txtSueldoNeto.Size = new Size(118, 25);
            txtSueldoNeto.TabIndex = 91;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(544, 40);
            label17.Name = "label17";
            label17.Size = new Size(78, 17);
            label17.TabIndex = 90;
            label17.Text = "Sueldo neto";
            // 
            // txtTDeducciones
            // 
            txtTDeducciones.ForeColor = Color.FromArgb(200, 146, 64);
            txtTDeducciones.Location = new Point(386, 270);
            txtTDeducciones.Name = "txtTDeducciones";
            txtTDeducciones.Size = new Size(118, 25);
            txtTDeducciones.TabIndex = 89;
            // 
            // txtAdelantoSueldo
            // 
            txtAdelantoSueldo.ForeColor = Color.FromArgb(200, 146, 64);
            txtAdelantoSueldo.Location = new Point(386, 208);
            txtAdelantoSueldo.Name = "txtAdelantoSueldo";
            txtAdelantoSueldo.Size = new Size(118, 25);
            txtAdelantoSueldo.TabIndex = 88;
            // 
            // txtSeguroMedico
            // 
            txtSeguroMedico.ForeColor = Color.FromArgb(200, 146, 64);
            txtSeguroMedico.Location = new Point(386, 156);
            txtSeguroMedico.Name = "txtSeguroMedico";
            txtSeguroMedico.Size = new Size(118, 25);
            txtSeguroMedico.TabIndex = 87;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(386, 246);
            label16.Name = "label16";
            label16.Size = new Size(113, 17);
            label16.TabIndex = 86;
            label16.Text = "Total deducciones";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(386, 188);
            label15.Name = "label15";
            label15.Size = new Size(103, 17);
            label15.TabIndex = 85;
            label15.Text = "Adelanto sueldo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(386, 130);
            label14.Name = "label14";
            label14.Size = new Size(97, 17);
            label14.TabIndex = 84;
            label14.Text = "Seguro medico";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(6, 10);
            label13.Name = "label13";
            label13.Size = new Size(86, 17);
            label13.TabIndex = 83;
            label13.Text = "Deducciones";
            // 
            // txtTAsignaciones
            // 
            txtTAsignaciones.ForeColor = Color.FromArgb(200, 146, 64);
            txtTAsignaciones.Location = new Point(213, 249);
            txtTAsignaciones.Name = "txtTAsignaciones";
            txtTAsignaciones.Size = new Size(138, 25);
            txtTAsignaciones.TabIndex = 82;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(215, 225);
            label12.Name = "label12";
            label12.Size = new Size(135, 17);
            label12.TabIndex = 81;
            label12.Text = "Total de Asignaciones";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 12);
            label11.Name = "label11";
            label11.Size = new Size(89, 17);
            label11.TabIndex = 80;
            label11.Text = "Asignaciones";
            label11.Click += label11_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(150, 178, 196);
            btnNuevo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.FromArgb(224, 214, 205);
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(713, 244);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 56);
            btnNuevo.TabIndex = 79;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(150, 178, 196);
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.FromArgb(224, 214, 205);
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(713, 159);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 56);
            btnGuardar.TabIndex = 78;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(150, 178, 196);
            btnCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.FromArgb(224, 214, 205);
            btnCalcular.Image = (Image)resources.GetObject("btnCalcular.Image");
            btnCalcular.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalcular.Location = new Point(713, 77);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 61);
            btnCalcular.TabIndex = 77;
            btnCalcular.Text = "Calcular";
            btnCalcular.TextAlign = ContentAlignment.MiddleRight;
            btnCalcular.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtBonoTransporte
            // 
            txtBonoTransporte.ForeColor = Color.FromArgb(200, 146, 64);
            txtBonoTransporte.Location = new Point(213, 192);
            txtBonoTransporte.Name = "txtBonoTransporte";
            txtBonoTransporte.Size = new Size(138, 25);
            txtBonoTransporte.TabIndex = 76;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(218, 166);
            label10.Name = "label10";
            label10.Size = new Size(128, 17);
            label10.TabIndex = 75;
            label10.Text = "Bono por transporte";
            // 
            // txtPrecioHora
            // 
            txtPrecioHora.ForeColor = Color.FromArgb(200, 146, 64);
            txtPrecioHora.Location = new Point(201, 315);
            txtPrecioHora.Name = "txtPrecioHora";
            txtPrecioHora.Size = new Size(118, 25);
            txtPrecioHora.TabIndex = 74;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(195, 295);
            label9.Name = "label9";
            label9.Size = new Size(133, 17);
            label9.TabIndex = 73;
            label9.Text = "Precio por hora extra";
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.ForeColor = Color.FromArgb(200, 146, 64);
            txtHorasExtras.Location = new Point(15, 315);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(118, 25);
            txtHorasExtras.TabIndex = 72;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 295);
            label8.Name = "label8";
            label8.Size = new Size(82, 17);
            label8.TabIndex = 71;
            label8.Text = "Horas extras";
            // 
            // txtSalarioB
            // 
            txtSalarioB.ForeColor = Color.FromArgb(200, 146, 64);
            txtSalarioB.Location = new Point(15, 252);
            txtSalarioB.Name = "txtSalarioB";
            txtSalarioB.Size = new Size(141, 25);
            txtSalarioB.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 234);
            label7.Name = "label7";
            label7.Size = new Size(84, 17);
            label7.TabIndex = 69;
            label7.Text = "Sueldo bruto";
            // 
            // txtPagoHE
            // 
            txtPagoHE.ForeColor = Color.FromArgb(200, 146, 64);
            txtPagoHE.Location = new Point(213, 134);
            txtPagoHE.Name = "txtPagoHE";
            txtPagoHE.Size = new Size(138, 25);
            txtPagoHE.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(221, 114);
            label6.Name = "label6";
            label6.Size = new Size(123, 17);
            label6.TabIndex = 67;
            label6.Text = "Monto horas extras";
            // 
            // txtApellido
            // 
            txtApellido.ForeColor = Color.FromArgb(200, 146, 64);
            txtApellido.Location = new Point(15, 201);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(141, 25);
            txtApellido.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 183);
            label5.Name = "label5";
            label5.Size = new Size(141, 17);
            label5.TabIndex = 65;
            label5.Text = "Apellido del empleado";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = Color.FromArgb(200, 146, 64);
            txtNombre.Location = new Point(15, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(141, 25);
            txtNombre.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 130);
            label4.Name = "label4";
            label4.Size = new Size(142, 17);
            label4.TabIndex = 63;
            label4.Text = "Nombre del empleado";
            // 
            // txtIdEmp
            // 
            txtIdEmp.ForeColor = Color.FromArgb(200, 146, 64);
            txtIdEmp.Location = new Point(6, 47);
            txtIdEmp.Name = "txtIdEmp";
            txtIdEmp.Size = new Size(162, 25);
            txtIdEmp.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(133, 17);
            label1.TabIndex = 58;
            label1.Text = "Codigo de empleado";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtIdEmp);
            groupBox2.Controls.Add(txtSueldoNeto);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(txtTDeducciones);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtAdelantoSueldo);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(txtSeguroMedico);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtPagoHE);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTAsignaciones);
            groupBox2.Controls.Add(txtSalarioB);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtHorasExtras);
            groupBox2.Controls.Add(txtBonoTransporte);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtPrecioHora);
            groupBox2.Location = new Point(12, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(689, 372);
            groupBox2.TabIndex = 93;
            groupBox2.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(150, 178, 196);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(44, 78);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(104, 49);
            btnBuscar.TabIndex = 98;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(pictureBox3);
            groupBox4.Location = new Point(399, 14);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(100, 100);
            groupBox4.TabIndex = 97;
            groupBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 33);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 93;
            pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(232, 11);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(100, 100);
            groupBox3.TabIndex = 96;
            groupBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 92;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(537, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 360);
            panel3.TabIndex = 94;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(370, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 361);
            panel2.TabIndex = 94;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(174, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 277);
            panel1.TabIndex = 94;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(11, 347);
            panel4.Name = "panel4";
            panel4.Size = new Size(378, 1);
            panel4.TabIndex = 95;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Right;
            btnMax.Cursor = Cursors.Hand;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(767, 3);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(45, 45);
            btnMax.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMax.TabIndex = 93;
            btnMax.TabStop = false;
            btnMax.Click += btnMax_Click;
            // 
            // frmPayrollSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 43);
            ClientSize = new Size(875, 650);
            Controls.Add(btnNuevo);
            Controls.Add(btnCalcular);
            Controls.Add(btnGuardar);
            Controls.Add(panel4);
            Controls.Add(groupBox2);
            Controls.Add(dgvPS);
            Controls.Add(pButtons);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPayrollSystem";
            Text = "frmPayrollSystem";
            Load += frmPayrollSystem_Load;
            pButtons.ResumeLayout(false);
            pButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPS).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pButtons;
        private PictureBox btnClose;
        private DataGridView dgvPS;
        private TextBox txtSueldoNeto;
        private Label label17;
        private TextBox txtTDeducciones;
        private TextBox txtAdelantoSueldo;
        private TextBox txtSeguroMedico;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox txtTAsignaciones;
        private Label label12;
        private Label label11;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnCalcular;
        private TextBox txtBonoTransporte;
        private Label label10;
        private TextBox txtPrecioHora;
        private Label label9;
        private TextBox txtHorasExtras;
        private Label label8;
        private TextBox txtSalarioB;
        private Label label7;
        private TextBox txtPagoHE;
        private Label label6;
        private TextBox txtApellido;
        private Label label5;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtIdEmp;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnBuscar;
        private PictureBox btnMax;
    }
}