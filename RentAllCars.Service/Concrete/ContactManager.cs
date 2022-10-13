using AutoMapper;
using RentAllCars.Data.DTOs;
using RentAllCars.Data.Entities;
using RentAllCars.DataAccess.Abstract;
using RentAllCars.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAllCars.Service.Concrete
{
	public class ContactManager : BaseService<ContactDto, Contact, IContactDal>, IContactService
	{
        public ContactManager(IContactDal repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public async override Task<List<ContactDto>> GetItems()
        {
            var data = _repository.GetQuery().ToList();
            var model = _mapper.Map<List<ContactDto>>(data);

            return await Task.FromResult(model);
        }
    }
}
