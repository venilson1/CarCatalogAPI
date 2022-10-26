using System.ComponentModel.DataAnnotations;

namespace CarCatalogAPI.Source.Core.DTOs
{
    public class CarDTO
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Model { get; set; }
        public string UrlImage { get; set; }
    }
}
