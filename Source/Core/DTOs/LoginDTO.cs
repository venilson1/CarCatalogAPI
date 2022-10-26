﻿using System.ComponentModel.DataAnnotations;

namespace CarCatalogAPI.Source.Core.DTOs
{
    public class LoginDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
