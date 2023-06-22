using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colibri.Dtos
{
    internal class ProveedorUpdateDto
    {
        [Required]
        public int ProveedorId { get; set; }
        [Required, StringLength(100)]
        public string? RazonSocial { get; set; }
        [Required, StringLength(20)]
        public string? RUC { get; set; }
        [Required]
        public int Telefono { get; set; }
        [Required, StringLength(100)]
        public string? Direccion { get; set; }
    }
}
