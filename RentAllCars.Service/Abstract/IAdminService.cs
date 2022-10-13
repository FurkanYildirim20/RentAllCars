using RentAllCars.Data.DTOs;
using RentAllCars.Data.Entities;
using RentAllCars.DataAccess.Concrete;

namespace RentAllCars.Service.Abstract
{
    public interface IAdminService : IBaseService<AdminDto, Admin, EfAdminDal>
    {
    }
}
