using System.ComponentModel.DataAnnotations;

namespace CarCatalogAPI.Source.Core.Entities
{
    public class UserEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
