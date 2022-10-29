using CarCatalogAPI.Source.Core.DTOs;
using CarCatalogAPI.Source.Core.Interfaces.Repositories;
using CarCatalogAPI.Source.Entities;
using CarCatalogAPI.Source.Infraestructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalogAPI.Source.Application.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        
        [HttpGet()]
        public async Task<ActionResult<List<CarEntity>>> FindAll(
                [FromQuery] int page = 0
            )
        {
            List<CarEntity> cars = await _carRepository.FindAll(page);
            var total = await _carRepository.Count();

            List<CarEntity> sortedCars = cars.OrderBy(x => x.Price).ToList();
            return Ok(new
            {
                total = total,
                page = page,
                data = sortedCars,
            });
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<CarEntity>> FindById(Guid id)
        {
            CarEntity car = await _carRepository.FindById(id);
            if(car == null) return NotFound();
            return Ok(car);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CarEntity>> Create([FromBody] CarDTO carDTO)
        {
            CarEntity car = new()
            {
                Name = carDTO.Name,
                Brand = carDTO.Brand,
                Model = carDTO.Model,
                Price = carDTO.Price,
                UrlImage = carDTO.UrlImage,
                CreatedAt = DateTime.Now
            };

            await _carRepository.Create(car);
            return CreatedAtAction(nameof(FindById), new {Id = car.Id}, car);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<CarEntity>> Update([FromBody] CarDTO carDTO, Guid id)
        {
            CarEntity carById = await _carRepository.FindById(id);
            if (carById == null) return NotFound();

            carById.Name = carDTO.Name;
            carById.Brand = carDTO.Brand;
            carById.Model = carDTO.Model;
            carById.Price = carDTO.Price;
            carById.UrlImage = carDTO.UrlImage;

            await _carRepository.Update(carById);
            
            return Ok(carById);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<CarEntity>> Delete(Guid id)
        {
            CarEntity car =  await _carRepository.FindById(id);
            if (car == null) return NotFound();

            bool isdelete = await _carRepository.Delete(car);
            return Ok(isdelete);
        }
    }
}
