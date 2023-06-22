using CiberCafeColibriAPI.Models;
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
    internal class VentaDto
    {
        public int VentasId { get; set; }
        [Required]
        public int ClienteId { get; set; }
        [Required]
        public int EmpleadoId { get; set; }
        [Required, StringLength(50)]
        public string? TipoComprobante { get; set; }
        [Required, StringLength(50)]
        public string? SerieComprobante { get; set; }
        public DateTime Fecha { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        [Required]
        public decimal Total { get; set; }
    }
}
