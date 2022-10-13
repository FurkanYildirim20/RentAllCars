using AutoMapper;
using RentAllCars.Data.DTOs;
using RentAllCars.Data.Entities;
using RentAllCars.DataAccess.Abstract;
using RentAllCars.Service.Abstract;

namespace RentAllCars.Service.Concrete
{
    public class CustomerManager : BaseService<CustomerDto, Customer, ICustomerDal>, ICustomerService
    {
        public CustomerManager(ICustomerDal repository, IMapper mapper) : base(repository, mapper)
        {

        }
        public async override Task<List<CustomerDto>> GetItems()
        {
            var data = _repository.GetQuery().ToList();
            var model = _mapper.Map<List<CustomerDto>>(data);

            return await Task.FromResult(model);
        }
    }
}
