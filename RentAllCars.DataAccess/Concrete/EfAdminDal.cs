using RentAllCars.Data.Entities;
using RentAllCars.DataAccess.Contexts;

namespace RentAllCars.DataAccess.Concrete
{
    public class EfAdminDal : GenericRepository<Admin, RcDbContext>
    {
        public EfAdminDal(RcDbContext context) : base(context)
        {
        }
    }
}
