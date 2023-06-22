namespace Colibri.AddProducts
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            pButtons = new Panel();
            btnCls = new PictureBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            btnClose = new PictureBox();
            groupBox1 = new GroupBox();
            txtEstado = new TextBox();
            txtStock = new TextBox();
            txtPrecioVenta = new TextBox();
            txtPrecioCompra = new TextBox();
            txtDescripcion = new TextBox();
            txtIdMarca = new TextBox();
            txtIdCategoria = new TextBox();
            txtIdProducto = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvProducto = new DataGridView();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCls).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // pButtons
            // 
            pButtons.Controls.Add(btnCls);
            pButtons.Controls.Add(pictureBox1);
            pButtons.Controls.Add(label9);
            pButtons.Controls.Add(btnClose);
            pButtons.Dock = DockStyle.Top;
            pButtons.Location = new Point(0, 0);
            pButtons.Name = "pButtons";
            pButtons.Size = new Size(800, 50);
            pButtons.TabIndex = 29;
            // 
            // btnCls
            // 
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
            label9.Size = new Size(148, 37);
            label9.TabIndex = 2;
            label9.Text = "Productos";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEstado);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtPrecioVenta);
            groupBox1.Controls.Add(txtPrecioCompra);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtIdMarca);
            groupBox1.Controls.Add(txtIdCategoria);
            groupBox1.Controls.Add(txtIdProducto);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(647, 224);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(476, 127);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(147, 23);
            txtEstado.TabIndex = 35;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(476, 97);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(147, 23);
            txtStock.TabIndex = 34;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(476, 70);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(147, 23);
            txtPrecioVenta.TabIndex = 33;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(476, 42);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(147, 23);
            txtPrecioCompra.TabIndex = 32;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(137, 132);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(174, 23);
            txtDescripcion.TabIndex = 31;
            // 
            // txtIdMarca
            // 
            txtIdMarca.Location = new Point(137, 102);
            txtIdMarca.Name = "txtIdMarca";
            txtIdMarca.Size = new Size(174, 23);
            txtIdMarca.TabIndex = 30;
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(137, 75);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(174, 23);
            txtIdCategoria.TabIndex = 29;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(136, 47);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(174, 23);
            txtIdProducto.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(344, 132);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 27;
            label8.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(344, 103);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 26;
            label7.Text = "Stock:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 76);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 25;
            label6.Text = "Precio de Venta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 47);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 24;
            label5.Text = "Precio de Compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 135);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 23;
            label4.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 106);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 22;
            label3.Text = "Id de la Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 79);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 21;
            label2.Text = "Id de la Categoría:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 50);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 20;
            label1.Text = "Id del Producto:";
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToAddRows = false;
            dgvProducto.AllowUserToDeleteRows = false;
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Dock = DockStyle.Bottom;
            dgvProducto.Location = new Point(0, 317);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            dgvProducto.RowTemplate.Height = 25;
            dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducto.Size = new Size(800, 294);
            dgvProducto.TabIndex = 27;
            dgvProducto.CellClick += dgvProducto_CellClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(56, 57, 62);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.ForeColor = Color.FromArgb(224, 214, 205);
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.Location = new Point(665, 243);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 57);
            btnLimpiar.TabIndex = 26;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(56, 57, 62);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.ForeColor = Color.FromArgb(224, 214, 205);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(665, 179);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 58);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(56, 57, 62);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.ForeColor = Color.FromArgb(224, 214, 205);
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.Location = new Point(665, 117);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(123, 56);
            btnModificar.TabIndex = 24;
            btnModificar.Text = "Modificar";
            btnModificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(56, 57, 62);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.ForeColor = Color.FromArgb(224, 214, 205);
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(665, 56);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 55);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 43);
            ClientSize = new Size(800, 611);
            Controls.Add(pButtons);
            Controls.Add(groupBox1);
            Controls.Add(dgvProducto);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            ForeColor = Color.FromArgb(200, 146, 64);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProducts";
            Text = "frmProducts";
            Load += frmProducts_Load;
            pButtons.ResumeLayout(false);
            pButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCls).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pButtons;
        private PictureBox pictureBox1;
        private Label label9;
        private PictureBox btnClose;
        private GroupBox groupBox1;
        private TextBox txtEstado;
        private TextBox txtStock;
        private TextBox txtPrecioVenta;
        private TextBox txtPrecioCompra;
        private TextBox txtDescripcion;
        private TextBox txtIdMarca;
        private TextBox txtIdCategoria;
        private TextBox txtIdProducto;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvProducto;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private PictureBox btnCls;
    }
}