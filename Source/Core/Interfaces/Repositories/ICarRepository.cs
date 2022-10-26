using CarCatalogAPI.Source.Entities;

namespace CarCatalogAPI.Source.Core.Interfaces.Repositories
{
    public interface ICarRepository
    {
        Task<List<CarEntity>> FindAll();
        Task<CarEntity> FindById(Guid carId);
        Task<CarEntity> Create(CarEntity car);
        Task<CarEntity> Update(CarEntity car);
        Task<bool> Delete(CarEntity car);
    }
}
