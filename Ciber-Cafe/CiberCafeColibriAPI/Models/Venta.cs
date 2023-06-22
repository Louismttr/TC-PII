using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiberCafeColibriAPI.Models
{
    public class Venta
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VentasId { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; }
        [ForeignKey("EmpleadoId")]
        public Empleado? Empleados { get; set; }
        public int EmpleadoId { get; set; }
        [Required, StringLength(50)]
        public string? TipoComprobante { get; set; }
        [Required, StringLength(50)]
        public string? SerieComprobante { get; set; }
        public DateTime Fecha { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Total { get; set; }
    }
}
