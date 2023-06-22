namespace Colibri.Registro_VyC
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtIdEmployee = new TextBox();
            label3 = new Label();
            txtTyptCom = new TextBox();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            btnImprimir = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvCompras = new DataGridView();
            groupBox2 = new GroupBox();
            label7 = new Label();
            txtRasson = new TextBox();
            txtID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            lblTotal = new Label();
            pButtons = new Panel();
            btnCls = new PictureBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            btnMax = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            groupBox2.SuspendLayout();
            pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCls).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtIdEmployee);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTyptCom);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 113);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 10);
            label8.Name = "label8";
            label8.Size = new Size(154, 17);
            label8.TabIndex = 6;
            label8.Text = "Información de compras:";
            // 
            // txtIdEmployee
            // 
            txtIdEmployee.Location = new Point(324, 66);
            txtIdEmployee.Name = "txtIdEmployee";
            txtIdEmployee.Size = new Size(147, 25);
            txtIdEmployee.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 43);
            label3.Name = "label3";
            label3.Size = new Size(123, 17);
            label3.TabIndex = 4;
            label3.Text = "Empleado Nombre:";
            // 
            // txtTyptCom
            // 
            txtTyptCom.Location = new Point(140, 69);
            txtTyptCom.Name = "txtTyptCom";
            txtTyptCom.Size = new Size(151, 25);
            txtTyptCom.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 43);
            label2.Name = "label2";
            label2.Size = new Size(139, 17);
            label2.TabIndex = 2;
            label2.Text = "Tipo de comprobante:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(6, 66);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(107, 25);
            dtpFecha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 0;
            label1.Text = "Fechaa:";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(58, 97, 119);
            btnImprimir.Image = (Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.Location = new Point(80, 575);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(114, 54);
            btnImprimir.TabIndex = 32;
            btnImprimir.Text = "Imprimir";
            btnImprimir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(58, 97, 119);
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(26, 443);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 55);
            btnClear.TabIndex = 31;
            btnClear.Text = "Limpiar";
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(58, 97, 119);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(26, 385);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 52);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(58, 97, 119);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(26, 326);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 53);
            btnEdit.TabIndex = 29;
            btnEdit.Text = "Editar";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(58, 97, 119);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(26, 265);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 55);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Guardar";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCompras
            // 
            dgvCompras.BackgroundColor = Color.FromArgb(21, 35, 43);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(21, 35, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(58, 97, 119);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(21, 35, 43);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(58, 97, 119);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCompras.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCompras.GridColor = Color.FromArgb(200, 146, 64);
            dgvCompras.Location = new Point(200, 197);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowTemplate.Height = 25;
            dgvCompras.Size = new Size(597, 454);
            dgvCompras.TabIndex = 33;
            dgvCompras.CellClick += dgvCompras_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtRasson);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(511, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(274, 113);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 10);
            label7.Name = "label7";
            label7.Size = new Size(165, 17);
            label7.TabIndex = 4;
            label7.Text = "Información del proveedor";
            // 
            // txtRasson
            // 
            txtRasson.Location = new Point(139, 66);
            txtRasson.Name = "txtRasson";
            txtRasson.Size = new Size(129, 25);
            txtRasson.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(14, 66);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 25);
            txtID.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 43);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 1;
            label5.Text = "Razón:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 43);
            label4.Name = "label4";
            label4.Size = new Size(20, 17);
            label4.TabIndex = 0;
            label4.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 528);
            label6.Name = "label6";
            label6.Size = new Size(39, 17);
            label6.TabIndex = 35;
            label6.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(67, 528);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(43, 17);
            lblTotal.TabIndex = 36;
            lblTotal.Text = "label7";
            // 
            // pButtons
            // 
            pButtons.Controls.Add(btnMax);
            pButtons.Controls.Add(btnCls);
            pButtons.Controls.Add(pictureBox1);
            pButtons.Controls.Add(label9);
            pButtons.Dock = DockStyle.Top;
            pButtons.Location = new Point(0, 0);
            pButtons.Name = "pButtons";
            pButtons.Size = new Size(800, 50);
            pButtons.TabIndex = 37;
            // 
            // btnCls
            // 
            btnCls.Cursor = Cursors.Hand;
            btnCls.Image = (Image)resources.GetObject("btnCls.Image");
            btnCls.Location = new Point(752, 2);
            btnCls.Name = "btnCls";
            btnCls.Size = new Size(45, 45);
            btnCls.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCls.TabIndex = 93;
            btnCls.TabStop = false;
            btnCls.Click += btnCls_Click;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(65, 9);
            label9.Name = "label9";
            label9.Size = new Size(284, 37);
            label9.TabIndex = 2;
            label9.Text = "Reporte de compras:";
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
            btnMax.TabIndex = 94;
            btnMax.TabStop = false;
            btnMax.Click += btnMax_Click;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 43);
            ClientSize = new Size(800, 650);
            Controls.Add(pButtons);
            Controls.Add(lblTotal);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(dgvCompras);
            Controls.Add(btnImprimir);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCompras";
            Text = "frmCompras";
            Load += frmCompras_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pButtons.ResumeLayout(false);
            pButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCls).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtIdEmployee;
        private Label label3;
        private TextBox txtTyptCom;
        private Label label2;
        private DateTimePicker dtpFecha;
        private Label label1;
        private Button btnImprimir;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvCompras;
        private GroupBox groupBox2;
        private TextBox txtRasson;
        private TextBox txtID;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label lblTotal;
        private Label label8;
        private Label label7;
        private Panel pButtons;
        private PictureBox pictureBox1;
        private Label label9;
        private PictureBox btnCls;
        private PictureBox btnMax;
    }
}