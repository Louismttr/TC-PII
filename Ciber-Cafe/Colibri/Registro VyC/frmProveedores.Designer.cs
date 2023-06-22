namespace Colibri.Registro_VyC
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnCls = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            pButtons = new Panel();
            btnCerrar = new PictureBox();
            pictureBox2 = new PictureBox();
            label14 = new Label();
            btnClose = new PictureBox();
            btnMax = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            SuspendLayout();
            // 
            // btnCls
            // 
            btnCls.BackColor = Color.FromArgb(195, 55, 77);
            btnCls.Image = (Image)resources.GetObject("btnCls.Image");
            btnCls.Location = new Point(619, 216);
            btnCls.Name = "btnCls";
            btnCls.Size = new Size(160, 53);
            btnCls.TabIndex = 21;
            btnCls.Text = "Limpiar";
            btnCls.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCls.UseVisualStyleBackColor = false;
            btnCls.Click += btnCls_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(195, 55, 77);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(453, 216);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 53);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(195, 55, 77);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(287, 216);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(160, 53);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Editar";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(195, 55, 77);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(121, 216);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 53);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Guardar";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(21, 35, 43);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(21, 35, 43);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(195, 55, 77);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = Color.FromArgb(200, 146, 64);
            dataGridView1.Location = new Point(0, 286);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(21, 35, 43);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(195, 55, 77);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 224);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(763, 136);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(81, 74);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 25);
            textBox4.TabIndex = 40;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(349, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 25);
            textBox2.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 77);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 38;
            label4.Text = "Dirreción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 37;
            label3.Text = "Télefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 27);
            label5.Name = "label5";
            label5.Size = new Size(36, 17);
            label5.TabIndex = 36;
            label5.Text = "RUC:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(495, 24);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(212, 25);
            textBox5.TabIndex = 35;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(294, 24);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 25);
            textBox3.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 30);
            label2.Name = "label2";
            label2.Size = new Size(85, 17);
            label2.TabIndex = 33;
            label2.Text = "Razón Social:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 32);
            label1.Name = "label1";
            label1.Size = new Size(23, 17);
            label1.TabIndex = 27;
            label1.Text = "ID:";
            // 
            // pButtons
            // 
            pButtons.Controls.Add(btnMax);
            pButtons.Controls.Add(btnCerrar);
            pButtons.Controls.Add(pictureBox2);
            pButtons.Controls.Add(label14);
            pButtons.Controls.Add(btnClose);
            pButtons.Dock = DockStyle.Top;
            pButtons.Location = new Point(0, 0);
            pButtons.Name = "pButtons";
            pButtons.Size = new Size(800, 50);
            pButtons.TabIndex = 43;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(752, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 45);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 93;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 92;
            pictureBox2.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(65, 9);
            label14.Name = "label14";
            label14.Size = new Size(333, 37);
            label14.TabIndex = 2;
            label14.Text = "Registro de proveedores";
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
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Right;
            btnMax.Cursor = Cursors.Hand;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(692, 2);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(45, 45);
            btnMax.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMax.TabIndex = 94;
            btnMax.TabStop = false;
            btnMax.Click += btnMax_Click;
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 43);
            ClientSize = new Size(800, 510);
            Controls.Add(pButtons);
            Controls.Add(groupBox1);
            Controls.Add(btnCls);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProveedores";
            Text = "frmProveedores";
            Load += frmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pButtons.ResumeLayout(false);
            pButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCls;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Panel pButtons;
        private PictureBox btnCerrar;
        private PictureBox pictureBox2;
        private Label label14;
        private PictureBox btnClose;
        private PictureBox btnMax;
    }
}