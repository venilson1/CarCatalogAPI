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
        public async Task<ActionResult<List<CarEntity>>> FindById(Guid id)
        {
            CarEntity car = await _carRepository.FindById(id);
            return Ok(car);
        }

        [HttpPost]
        public async Task<ActionResult<CarEntity>> Create([FromBody] CarEntity car)
        {
            CarEntity carEntity = await _carRepository.Create(car);
            return Ok(carEntity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CarEntity>> Update([FromBody] CarEntity carDTO, Guid id)
        {
            carDTO.Id = id;
            CarEntity carEntity = await _carRepository.Update(carDTO, id);
            return Ok(carEntity);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CarEntity>> Delete(Guid id)
        {
            bool isdelete = await _carRepository.Delete(id);
            return Ok(isdelete);
        }
    }
}
