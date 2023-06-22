using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiberCafeColibriAPI.Models
{
    public class Categoria
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoriaId { get; set; }
        [Required, StringLength(100)]
        public string? Categorias { get; set; }
    }
}