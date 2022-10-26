using CarCatalogAPI.Source.Core.Interfaces.Repositories;
using CarCatalogAPI.Source.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarCatalogAPI.Source.Infraestructure.Persistence
{
    public class CarRepository : ICarRepository
    {
        private readonly CarCatalogDbContext _dbContex;
        public CarRepository(CarCatalogDbContext dbContex)
        {
            _dbContex = dbContex;
        }
        public async Task<List<CarEntity>> FindAll()
        {
            return await _dbContex.Cars.ToListAsync();
        }

        public async Task<CarEntity> FindById(Guid id)
        {
            return await _dbContex.Cars.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<CarEntity> Create(CarEntity car)
        {
            await _dbContex.Cars.AddAsync(car);
            await _dbContex.SaveChangesAsync();
            return car;

        }
        public async Task<CarEntity> Update(CarEntity carDTO, Guid id)
        {
            CarEntity carEntity = await FindById(id);

            if (carEntity == null) throw new Exception($"carro {id} não encontrado");

            carEntity.Name = carDTO.Name;
            carEntity.Brand = carDTO.Brand;
            carEntity.Model = carDTO.Model;
            carEntity.UrlImage = carDTO.UrlImage;

            _dbContex.Cars.Update(carEntity);
            await _dbContex.SaveChangesAsync();

            return carEntity;
        }

        public async Task<bool> Delete(Guid id)
        {
            CarEntity carEntity = await FindById(id);

            if (carEntity == null) throw new Exception($"carro {id} não encontrado");

            _dbContex.Cars.Remove(carEntity);
            await _dbContex.SaveChangesAsync();
            return true;
        }
    }
}
