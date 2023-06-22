using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiberCafeColibriAPI.Models
{
    public class DashBoard
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DashBoardId { get; set; }
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public Producto? productos { get; set; }
        public int MarcasId { get; set; }
        [ForeignKey("IMarcaId")]
        public Marca? Marcas { get; set; }
        public int CategoriasId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria? Categorias { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente? Clientes { get; set; }
        public int ProveedorId { get; set; }
        [ForeignKey("ProveedorId")]
        public Proveedor? Proveedores { get; set; }
        public int EmpleadoId { get; set; }
        [ForeignKey("EmpleadoId")]
        public Empleado? Empleados { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalVentas { get; set; }
    }
}
