using RentAllCars.Data.Entities;
using RentAllCars.DataAccess.Contexts;

namespace RentAllCars.DataAccess.Concrete
{
    public class EfCustomerDal : GenericRepository<Customer, RcDbContext>
    {
        public EfCustomerDal(RcDbContext context) : base(context)
        {
        }
    }
}
