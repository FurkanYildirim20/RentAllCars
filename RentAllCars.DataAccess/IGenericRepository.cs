using RentAllCars.Core.BaseEntity;

namespace RentAllCars.DataAccess
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        public IEnumerable<TEntity> GetAll();
        public IQueryable<TEntity> GetQuery();
        public TEntity GetById(int id);
    }
}
