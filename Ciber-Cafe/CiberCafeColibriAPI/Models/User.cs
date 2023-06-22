using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiberCafeColibriAPI.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string? UserName { get; set; }
        public int Password { get; set; }
        [StringLength(50)]
        public string? Role { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
    }
}
