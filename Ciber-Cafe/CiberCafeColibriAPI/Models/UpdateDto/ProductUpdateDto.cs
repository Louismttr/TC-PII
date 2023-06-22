using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CiberCafeColibriAPI.Models.UpdateDto
{
    public class ProductUpdateDto
    {
        [Required]
        public int ProductoId { get; set; }
        [Required]
        public int CategoriaId { get; set; }
        [Required]
        public int MarcaId { get; set; }
        [Required]
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
