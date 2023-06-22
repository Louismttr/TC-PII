using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiberCafeColibriAPI.Models
{
    public class Cliente
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClienteId { get; set; }
        [Required, StringLength(50)]
        public string? NombresCliente { get; set; }
        [StringLength(50)]
        public string? ApellidosCliente { get; set; }
        [StringLength(50)]
        public string? RUC { get; set; }
        public int Telefono { get; set; }
        [StringLength(100)]
        public string? Direccion { get; set; }
    }
}