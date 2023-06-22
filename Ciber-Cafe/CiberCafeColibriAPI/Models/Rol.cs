using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiberCafeColibriAPI.Models
{
    public class Rol
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RolId { get; set; }
        [Required, StringLength(80)]
        public string? RolesEmpleado { get; set; }
    }
}
