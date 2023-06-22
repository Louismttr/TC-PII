using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiberCafeColibriAPI.Models
{
    public class Nomina
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NomindaId { get; set; }
        public int EmpleadoId { get; set; }
        [ForeignKey("EmpleadoId")]
        public Empleado? Empleado { get; set;}
        [Required, StringLength(50)]
        public string? Nombre { get; set; }
        [Required, StringLength(50)]
        public string? Apellido { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal SalarioBruto { get; set; }
        public int HorasExtras { get; set; }
        public int PrecioHorasExtras { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PagoHorasExtras { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal BonoTransporte { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalAsignaciones { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal SeguroMedico { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal AdelantoSueldo { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalDeducciones { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal SalarioNeto { get; set; }

    }
}
