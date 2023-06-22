using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiberCafeColibriAPI.Models.Dto
{
    public class EmpleadoDto
    {
        public int EmpleadoId { get; set; }
        public int RolId { get; set; }
        [Required, StringLength(50)]
        public string? NombresEmpleado { get; set; }
        [StringLength(50)]
        public string? ApellidosEmpleados { get; set; }
        [StringLength(50)]
        public string? DNI { get; set; }
        [StringLength(25)]
        public string? Contraseña { get; set; }
        public int Telofono { get; set; }
        [StringLength(100)]
        public string? Direccion { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Salario { get; set; }
    }
}
