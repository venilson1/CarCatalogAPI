using CarCatalogAPI.Source.Core.DTOs;
using CarCatalogAPI.Source.Core.Interfaces.Repositories;
using CarCatalogAPI.Source.Entities;
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
        
        [HttpGet]
        public async Task<ActionResult<List<CarEntity>>> FindAll()
        {
            List<CarEntity> cars = await _carRepository.FindAll();
            return Ok(cars);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<CarEntity>> FindById(Guid id)
        {
            CarEntity car = await _carRepository.FindById(id);
            if(car == null) return NotFound();
            return Ok(car);
        }

        [HttpPost]
        public async Task<ActionResult<CarEntity>> Create([FromBody] CarDTO carDTO)
        {
            CarEntity car = new()
            {
                Name = carDTO.Name,
                Brand = carDTO.Brand,
                Model = carDTO.Model,
                UrlImage = carDTO.UrlImage,
                CreatedAt = DateTime.Now
            };

            await _carRepository.Create(car);
            return CreatedAtAction(nameof(FindById), new {Id = car.Id}, car);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CarEntity>> Update([FromBody] CarDTO carDTO, Guid id)
        {
            CarEntity carEntity = await _carRepository.FindById(id);
            if (carEntity == null) return NotFound();

            CarEntity car = new()
            {
                Id = id,
                Name = carDTO.Name,
                Brand = carDTO.Brand,
                Model = carDTO.Model,
                UrlImage = carDTO.UrlImage,
            };

            car = await _carRepository.Update(car);
            
            return Ok(car);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CarEntity>> Delete(Guid id)
        {
            CarEntity car =  await _carRepository.FindById(id);
            if (car == null) return NotFound();

            bool isdelete = await _carRepository.Delete(car);
            return Ok(isdelete);
        }
    }
}
