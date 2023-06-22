namespace Colibri.NyD
{
    partial class frmAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEmployee));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pButtons = new Panel();
            btnMax = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnClose = new PictureBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            groupBox1 = new GroupBox();
            txtSalario = new TextBox();
            label10 = new Label();
            txtDireccion = new TextBox();
            label9 = new Label();
            txtTelefono = new TextBox();
            label8 = new Label();
            txtContra = new TextBox();
            label7 = new Label();
            txtDNI = new TextBox();
            label6 = new Label();
            txtApellido = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtIdRol = new TextBox();
            label3 = new Label();
            txtIdEmp = new TextBox();
            label11 = new Label();
            dgvEmployee = new DataGridView();
            btnLimpiar = new Button();
            pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
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
            pButtons.TabIndex = 1;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Right;
            btnMax.Cursor = Cursors.Hand;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(758, 5);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(45, 45);
            btnMax.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMax.TabIndex = 93;
            btnMax.TabStop = false;
            btnMax.Click += btnMax_Click;
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
            label2.Size = new Size(269, 37);
            label2.TabIndex = 2;
            label2.Text = "Agregar Empleados";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(818, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 45);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(195, 55, 77);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(698, 317);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(154, 53);
            btnEliminar.TabIndex = 44;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(195, 55, 77);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.Location = new Point(485, 317);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(154, 53);
            btnActualizar.TabIndex = 43;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(195, 55, 77);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(259, 317);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(154, 53);
            btnGuardar.TabIndex = 42;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSalario);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtContra);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtIdRol);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIdEmp);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(39, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(813, 239);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            // 
            // txtSalario
            // 
            txtSalario.ForeColor = Color.FromArgb(200, 146, 64);
            txtSalario.Location = new Point(567, 184);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(211, 25);
            txtSalario.TabIndex = 59;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(568, 164);
            label10.Name = "label10";
            label10.Size = new Size(51, 17);
            label10.TabIndex = 58;
            label10.Text = "Salario:";
            // 
            // txtDireccion
            // 
            txtDireccion.ForeColor = Color.FromArgb(200, 146, 64);
            txtDireccion.Location = new Point(568, 116);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(211, 25);
            txtDireccion.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(568, 94);
            label9.Name = "label9";
            label9.Size = new Size(65, 17);
            label9.TabIndex = 56;
            label9.Text = "Direccion:";
            // 
            // txtTelefono
            // 
            txtTelefono.ForeColor = Color.FromArgb(200, 146, 64);
            txtTelefono.Location = new Point(568, 48);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(211, 25);
            txtTelefono.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(572, 21);
            label8.Name = "label8";
            label8.Size = new Size(61, 17);
            label8.TabIndex = 54;
            label8.Text = "Telefono:";
            // 
            // txtContra
            // 
            txtContra.ForeColor = Color.FromArgb(200, 146, 64);
            txtContra.Location = new Point(341, 184);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(167, 25);
            txtContra.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(341, 164);
            label7.Name = "label7";
            label7.Size = new Size(77, 17);
            label7.TabIndex = 52;
            label7.Text = "Contraseña:";
            // 
            // txtDNI
            // 
            txtDNI.ForeColor = Color.FromArgb(200, 146, 64);
            txtDNI.Location = new Point(338, 114);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(170, 25);
            txtDNI.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(341, 94);
            label6.Name = "label6";
            label6.Size = new Size(33, 17);
            label6.TabIndex = 50;
            label6.Text = "DNI:";
            // 
            // txtApellido
            // 
            txtApellido.ForeColor = Color.FromArgb(200, 146, 64);
            txtApellido.Location = new Point(338, 48);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(170, 25);
            txtApellido.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 21);
            label5.Name = "label5";
            label5.Size = new Size(144, 17);
            label5.TabIndex = 48;
            label5.Text = "Apellido del empleado:";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = Color.FromArgb(200, 146, 64);
            txtNombre.Location = new Point(68, 184);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(162, 25);
            txtNombre.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 164);
            label4.Name = "label4";
            label4.Size = new Size(145, 17);
            label4.TabIndex = 46;
            label4.Text = "Nombre del empleado:";
            // 
            // txtIdRol
            // 
            txtIdRol.ForeColor = Color.FromArgb(200, 146, 64);
            txtIdRol.Location = new Point(68, 114);
            txtIdRol.Name = "txtIdRol";
            txtIdRol.Size = new Size(142, 25);
            txtIdRol.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 94);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 44;
            label3.Text = "Codigo del Rol:";
            // 
            // txtIdEmp
            // 
            txtIdEmp.ForeColor = Color.FromArgb(200, 146, 64);
            txtIdEmp.Location = new Point(68, 48);
            txtIdEmp.Name = "txtIdEmp";
            txtIdEmp.Size = new Size(142, 25);
            txtIdEmp.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(68, 21);
            label11.Name = "label11";
            label11.Size = new Size(136, 17);
            label11.TabIndex = 42;
            label11.Text = "Codigo de empleado:";
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.AllowUserToDeleteRows = false;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.BackgroundColor = Color.FromArgb(21, 35, 43);
            dgvEmployee.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(21, 35, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 146, 64);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Dock = DockStyle.Bottom;
            dgvEmployee.GridColor = Color.FromArgb(200, 146, 64);
            dgvEmployee.Location = new Point(0, 388);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(21, 35, 43);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(195, 55, 77);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvEmployee.RowTemplate.Height = 25;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(875, 262);
            dgvEmployee.TabIndex = 47;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(195, 55, 77);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.ForeColor = Color.FromArgb(224, 214, 205);
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.Location = new Point(39, 315);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(154, 57);
            btnLimpiar.TabIndex = 48;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 43);
            ClientSize = new Size(875, 650);
            Controls.Add(btnLimpiar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvEmployee);
            Controls.Add(btnEliminar);
            Controls.Add(groupBox1);
            Controls.Add(pButtons);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddEmployee";
            Text = "AddEmployee";
            Load += frmAddEmployee_Load;
            pButtons.ResumeLayout(false);
            pButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pButtons;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox btnClose;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private GroupBox groupBox1;
        private TextBox txtSalario;
        private Label label10;
        private TextBox txtDireccion;
        private Label label9;
        private TextBox txtTelefono;
        private Label label8;
        private TextBox txtContra;
        private Label label7;
        private TextBox txtDNI;
        private Label label6;
        private TextBox txtApellido;
        private Label label5;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtIdRol;
        private Label label3;
        private TextBox txtIdEmp;
        private Label label11;
        private DataGridView dgvEmployee;
        private PictureBox btnMax;
        private Button btnLimpiar;
    }
}