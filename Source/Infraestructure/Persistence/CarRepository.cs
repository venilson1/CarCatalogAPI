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
        public async Task<List<CarEntity>> FindAll(int page)
        {
            return await _dbContex.Cars.OrderBy(x => x.Price).AsNoTracking().Skip((page * 8)).Take(8).ToListAsync();
        }
        //page = 1 --- 8 ao 16
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
        public async Task<CarEntity> Update(CarEntity car)
        {
                _dbContex.Cars.Update(car);
                await _dbContex.SaveChangesAsync();

                return car;
        }

        public async Task<bool> Delete(CarEntity car)
        {
            _dbContex.Cars.Remove(car);
            await _dbContex.SaveChangesAsync();
            return true;
        }

        public async Task<int> Count()
        {
            var total = _dbContex.Cars.Count();
            return total;
        }
    }
}
