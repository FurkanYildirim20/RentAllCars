using AutoMapper;
using RentAllCars.Data.DTOs;
using RentAllCars.Data.Entities;
using RentAllCars.DataAccess.Abstract;
using RentAllCars.Service.Abstract;

namespace RentAllCars.Service.Concrete
{
	public class OwnerManager : BaseService<OwnerDto, Owner, IOwnerDal>, IOwnerService
	{
		public OwnerManager(IOwnerDal repository, IMapper mapper) : base(repository, mapper)
		{
		}

		public async override Task<List<OwnerDto>> GetItems()
		{
			var data = _repository.GetQuery().ToList();
			var model = _mapper.Map<List<OwnerDto>>(data);

			return await Task.FromResult(model);
		}
	}
}
