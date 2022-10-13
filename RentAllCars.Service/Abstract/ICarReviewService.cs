using RentAllCars.Data.DTOs;
using RentAllCars.Data.Entities;
using RentAllCars.DataAccess.Concrete;

namespace RentAllCars.Service.Abstract
{
    public interface ICarReviewService : IBaseService<CarReviewDto, CarReview, EfCarReviewDal>
    {
    }
}
