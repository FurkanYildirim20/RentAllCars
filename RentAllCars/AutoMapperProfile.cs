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
            CreateMap<Admin, AdminDto>().ReverseMap();
            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<CarReview, CarReviewDto>().ReverseMap();
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Owner, OwnerDto>().ReverseMap();
        }
    }
}
