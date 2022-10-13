using RentAllCars.Data.Entities;
using RentAllCars.DataAccess.Contexts;

namespace RentAllCars.DataAccess.Concrete
{
    public class EfAboutDal : GenericRepository<About, RcDbContext>
    {
        public EfAboutDal(RcDbContext context) : base(context)
        {
        }
    }
}
