using RentAllCars.Data.DTOs;
using RentAllCars.Data.Entities;
using RentAllCars.DataAccess.Abstract;

namespace RentAllCars.Service.Abstract
{
    public interface IOwnerService : IBaseService<OwnerDto, Owner, IOwnerDal>
    {
    }
}
