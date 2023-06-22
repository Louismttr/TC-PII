using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiberCafeColibriAPI.Models
{
    public class Producto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductoId { get; set; }
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria? Categorias { get; set; }
        public int MarcaId { get; set; }
        [ForeignKey("MarcaId")]
        public Marca? Marcas { get; set; }
        [StringLength(100)]
        public string? Descripcion { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PrecioCompra { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        [StringLength(50)]
        public string? Estado { get; set; }
    }
}