using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiberCafeColibriAPI.Models
{
    public class Compra
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CompraId { get; set; }
        public string? SereiComprobante { get; set; }
        public DateTime Fecha { get; set; }
        public int ProveedorId { get; set; }
        [ForeignKey("ProveedorId")]
        public Proveedor? proveedores { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Total { get; set; }
    }
}