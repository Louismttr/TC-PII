using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiberCafeColibriAPI.Models
{
    public class DetallesCompra
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DetalleCompraId { get; set; }
        public int CompraId { get; set; }
        [ForeignKey("CompraId")]
        public Compra? Compras { get; set; }
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public Producto? productos { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PrecioCompra { get; set; }
        public int Cantidad { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal SubTotal { get; set; }
    }
}
