using RentAllCars.Data.Entities;
using RentAllCars.DataAccess.Contexts;

namespace RentAllCars.DataAccess.Concrete
{
    public class EfCarDal : GenericRepository<Car, RcDbContext>
    {
        public EfCarDal(RcDbContext context) : base(context)
        {
        }
    }
}
