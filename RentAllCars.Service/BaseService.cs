using AutoMapper;
using RentAllCars.Core.BaseDTO;
using RentAllCars.Core.BaseEntity;
using RentAllCars.DataAccess;
using RentAllCars.DataAccess.Abstract;

namespace RentAllCars.Service
{
    public class BaseService<TDto, TEntity, TDal> : IBaseService<TDto, TEntity, TDal>
        where TDto : IDto
        where TEntity : class, IEntity, new()
        where TDal : IGenericRepository<TEntity>
    {
        protected readonly TDal _repository;
        protected readonly IMapper _mapper;
        private IOwnerDal repository;
        private IMapper mapper;
        private ICustomerDal repository1;
		private ICarReviewDal repository2;
		private ICarDal repository3;
		private IAboutDal repository4;
		private IContactDal repository5;

		public BaseService(IOwnerDal repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public BaseService(ICustomerDal repository1, IMapper mapper)
        {
            this.repository1 = repository1;
            this.mapper = mapper;
        }

		public BaseService(ICarReviewDal repository2, IMapper mapper)
		{
			this.repository2 = repository2;
			this.mapper = mapper;
		}

		public BaseService(ICarDal repository3, IMapper mapper)
		{
			this.repository3 = repository3;
			this.mapper = mapper;
		}

		public BaseService(IAboutDal repository4, IMapper mapper)
		{
			this.repository4 = repository4;
			this.mapper = mapper;
		}

		public BaseService(IContactDal repository5, IMapper mapper)
		{
			this.repository5 = repository5;
			this.mapper = mapper;
		}

		public virtual async Task Delete(int id)
        {
            await Task.Run(() => { _repository.Delete(id); });
        }

        public virtual async Task<TDto> GetById(int id)
        {
            return await Task.FromResult(_mapper.Map<TDto>(_repository.GetById(id)));
        }

        public virtual async Task<List<TDto>> GetItems()
        {
            return _mapper.Map<List<TDto>>(_repository.GetAll());
        }

        public virtual async Task<TDto> Insert(TDto model)
        {
            var entity = _mapper.Map<TEntity>(model);
            _repository.Add(entity);
            return await Task.FromResult(model);
        }

        public virtual async Task<TDto> Update(TDto model)
        {
            var entity = _mapper.Map<TEntity>(model);
            _repository.Update(entity);
            return await Task.FromResult(model);
        }
    }
}
