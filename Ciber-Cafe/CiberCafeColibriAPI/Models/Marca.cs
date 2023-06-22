using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiberCafeColibriAPI.Models
{
    public class Marca
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IMarcaId { get; set; }
        [Required, StringLength(100)]
        public string? Marcas { get; set; }
    }
}