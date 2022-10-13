using RentAllCars.Data.Entities;
using RentAllCars.DataAccess.Contexts;

namespace RentAllCars.DataAccess.Concrete
{
    public class EfOwnerDal : GenericRepository<Owner, RcDbContext>
    {
        public EfOwnerDal(RcDbContext context) : base(context)
        {
        }
    }
}
