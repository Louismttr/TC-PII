﻿using System.ComponentModel.DataAnnotations;

namespace CiberCafeColibriAPI.Models.Dto
{
    public class ClienteDto
    {
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
