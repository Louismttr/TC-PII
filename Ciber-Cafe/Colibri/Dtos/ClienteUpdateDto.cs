using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colibri.Dtos
{
    internal class ClienteUpdateDto
    {
        [Required]
        public int ClienteId { get; set; }
        [Required, StringLength(50)]
        public string? NombresCliente { get; set; }
        [Required]
        [StringLength(50)]
        public string? ApellidosCliente { get; set; }
        [Required]
        [StringLength(50)]
        public string? RUC { get; set; }
        [Required]
        public int Telefono { get; set; }
        [Required]
        [StringLength(100)]
        public string? Direccion { get; set; }
    }
}
