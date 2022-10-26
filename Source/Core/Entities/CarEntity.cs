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
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Model { get; set; }
        public string UrlImage { get; set; }
    }
}
