using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiberCafeColibriAPI.Models
{
    public class DetallesVenta
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DetalleVentaId { get; set; }
        public int VentaId { get; set;}
        [ForeignKey("VentasId")]
        public Venta? Ventas { get; set;}
        public int ProductoId { get; set;}
        [ForeignKey("ProductoId")]
        public Producto? Productos { get; set;}
        [Column(TypeName = "decimal(18,4)")]
        public decimal PrecioVenta { get; set;}
        public int Cantidad { get; set;}
        [Column(TypeName = "decimal(18,4)")]
        public decimal SubTotal { get; set;}

    }
}
