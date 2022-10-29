using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CarCatalogAPI.Source.Entities
{
    public class CarEntity
    {
        public CarEntity()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public double Price { get; set; }
        public string UrlImage { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
