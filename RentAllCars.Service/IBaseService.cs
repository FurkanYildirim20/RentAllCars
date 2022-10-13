using RentAllCars.Core.BaseDTO;
using RentAllCars.Core.BaseEntity;
using RentAllCars.DataAccess;

namespace RentAllCars.Service
{
    public interface IBaseService<TDto, TEntity, TDal> where TDto : IDto where TEntity : class, IEntity, new()
        where TDal : IGenericRepository<TEntity>
    {
        Task<List<TDto>> GetItems();
        Task<TDto> Insert(TDto model);
        Task<TDto> Update(TDto model);
        Task Delete(int id);
        Task<TDto> GetById(int id);
    }
}
