using RentAllCars.Data.Entities;
using RentAllCars.DataAccess.Contexts;

namespace RentAllCars.DataAccess.Concrete
{
    public class EfCarReviewDal : GenericRepository<CarReview, RcDbContext>
    {
        public EfCarReviewDal(RcDbContext context) : base(context)
        {
        }
    }
}
