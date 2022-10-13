using RentAllCars.Data.DTOs;
using RentAllCars.Data.Entities;
using RentAllCars.DataAccess.Concrete;

namespace RentAllCars.Service.Abstract
{
    public interface IAboutService : IBaseService<AboutDto, About, EfAboutDal>
    {
    }
}
