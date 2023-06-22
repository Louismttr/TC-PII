using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiberCafeColibriAPI.Models
{
    public class Proveedor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProveedorId { get; set; }
        [Required, StringLength(100)]
        public string? RazonSocial { get; set; }
        [StringLength(20)]
        public string? RUC { get; set; }
        public int Telefono { get; set; }
        [StringLength(100)]
        public string? Direccion { get; set; }

    }
}