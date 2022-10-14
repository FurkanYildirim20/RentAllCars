using AutoMapper;
using RentAllCars.Data.DTOs;
using RentAllCars.Data.Entities;

namespace RentAllCars
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<About, AboutDto>().ReverseMap();
            CreateMap<Car, CarDetailDto>().ReverseMap();
        }
    }
}
