using CiberCafeColibriAPI.Models;
using Colibri.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Colibri.AddProducts
{
    public partial class frmProducts : Form
    {
        private static int productId = 0;
        public frmProducts()
        {
            InitializeComponent();
        }
        private async void GetAllProducts()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7253/api/Productos"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var products = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<List<ProductDto>>(products);
                        dgvProducto.DataSource = result.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de productos: {response.StatusCode}");
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Valida() == "si")
            {
                AddProduct();
            }
            else
            {
                MessageBox.Show("El error se encuentra en " + Valida(), "ERROR DE ESPACIOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void AddProduct()
        {
            ProductCreateDto productCreateDto = new ProductCreateDto();
            productCreateDto.ProductoId = int.Parse(txtIdProducto.Text);
            productCreateDto.CategoriaId = int.Parse(txtIdCategoria.Text);
            productCreateDto.MarcaId = int.Parse(txtIdCategoria.Text);
            productCreateDto.Descripcion = txtDescripcion.Text;
            productCreateDto.PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
            productCreateDto.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
            productCreateDto.Stock = int.Parse(txtStock.Text);
            productCreateDto.Estado = txtEstado.Text;
            using (var client = new HttpClient())
            {
                var serializeProduct = JsonConvert.SerializeObject(productCreateDto);
                var content = new StringContent(serializeProduct, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7253/api/Productos", content);

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Producto agregado");
                else
                    MessageBox.Show($"Error al guardar el producto: {response.Content.ReadAsStringAsync().Result}");
            }
            Clear();
            GetAllProducts();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            GetAllProducts();
        }

        private void Clear()
        {
            txtIdProducto.Focus();
            txtDescripcion.Clear();
            txtIdProducto.Clear();
            txtIdCategoria.Clear();
            txtIdMarca.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
            txtEstado.Clear();
            productId = 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Valida() == "si")
            {
                if (productId != 0)
                    UpdateProduct();
            }
            else
            {
                MessageBox.Show("El error se encuentra en " + Valida(), "ERROR DE ESPACIOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void UpdateProduct()
        {
            ProductUpdateDto productUpdateDto = new ProductUpdateDto();
            productUpdateDto.ProductoId = int.Parse(txtIdProducto.Text);
            productUpdateDto.CategoriaId = int.Parse(txtIdCategoria.Text);
            productUpdateDto.MarcaId = int.Parse(txtIdCategoria.Text);
            productUpdateDto.Descripcion = txtDescripcion.Text;
            productUpdateDto.PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
            productUpdateDto.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
            productUpdateDto.Stock = int.Parse(txtStock.Text);
            productUpdateDto.Estado = txtEstado.Text;

            using (var client = new HttpClient())
            {
                var student = JsonConvert.SerializeObject(productUpdateDto);
                var content = new StringContent(student, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7253/api/Productos", productUpdateDto.ProductoId), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Producto actualizado");
                else
                    MessageBox.Show($"Error al actualizar el producto: {response.StatusCode}");
            }
            Clear();
            GetAllProducts();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            int idProducto = int.Parse(txtIdProducto.Text);

            string urlApi = $"https://localhost:7253/api/Productos/{idProducto}";

            try
            {
                HttpResponseMessage response = await client.DeleteAsync(urlApi);


                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto borrado correctamente");
                    GetAllProducts();
                    Clear();
                }
                else
                {

                    MessageBox.Show("Error al borrar el producto. Por favor, verifica el ID e intenta nuevamente.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* foreach (DataGridViewRow row in dgvProducto.Rows)
             {
                 if (row.Index == e.RowIndex)
                 {
                     productId = int.Parse(row.Cells[0].Value.ToString());
                     GetProductById(productId);
                 }
             }*/
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducto.Rows[e.RowIndex];
                txtIdProducto.Text = row.Cells["ProductoId"].Value.ToString();
                txtIdCategoria.Text = row.Cells["CategoriaId"].Value.ToString();
                txtIdMarca.Text = row.Cells["MarcaId"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtPrecioCompra.Text = row.Cells["PrecioCompra"].Value.ToString();
                txtPrecioVenta.Text = row.Cells["PrecioVenta"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                txtEstado.Text = row.Cells["Estado"].Value.ToString();
            }
        }
        private async void GetProductById(int productId)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}",
                    "https://localhost:7253/api/Productos", productId));
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    ProductDto productDto = JsonConvert.DeserializeObject<ProductDto>(data);
                    txtIdProducto.Text = productDto.ProductoId.ToString();
                    txtDescripcion.Text = productDto.Descripcion;
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el producto: {response.StatusCode}");
                }
            }
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Valida
        private string Valida()
        {
            if (txtIdProducto.Text.Trim().Length == 0)
            {
                txtIdProducto.Clear();
                txtIdProducto.Focus();
                return "Id del Producto";
            }
            else if (txtIdCategoria.Text.Trim().Length == 0)
            {
                txtIdCategoria.Clear();
                txtIdCategoria.Focus();
                return "Id de la Categoría";
            }
            else if (txtIdMarca.Text.Trim().Length == 0)
            {
                txtIdMarca.Clear();
                txtIdMarca.Focus();
                return "Id de la Marca";
            }
            else if (txtDescripcion.Text.Trim().Length == 0)
            {
                txtDescripcion.Clear();
                txtDescripcion.Focus();
                return "Descripción";
            }
            else if (txtPrecioCompra.Text.Trim().Length == 0)
            {
                txtPrecioCompra.Clear();
                txtPrecioCompra.Focus();
                return "Precio de Compra";
            }
            else if (txtPrecioVenta.Text.Trim().Length == 0)
            {
                txtPrecioVenta.Clear();
                txtPrecioVenta.Focus();
                return "Precio de Venta";
            }
            else if (txtStock.Text.Trim().Length == 0)
            {
                txtStock.Clear();
                txtStock.Focus();
                return "Stock";
            }
            else if (txtEstado.Text.Trim().Length == 0)
            {
                txtEstado.Clear();
                txtEstado.Focus();
                return "Estado";
            }
            return "si";
        }
        #endregion
    }
}
