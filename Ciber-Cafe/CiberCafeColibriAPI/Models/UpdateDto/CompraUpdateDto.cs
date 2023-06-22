using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafeColibriAPI.Models.UpdateDto
{
    public class CompraUpdateDto
    {
        [Required]
        public int CompraId { get; set; }
        [Required]
        public string? SereiComprobante { get; set; }
        public DateTime Fecha { get; set; }
        [Required]
        public int ProveedorId { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Total { get; set; }
    }
}
