using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colibri.Dtos
{
    internal class EmpleadoCreateDto
    {
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
