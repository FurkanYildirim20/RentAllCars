using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using RentAllCars.Core.CrossCuttingConcern.Caching;
using RentAllCars.Core.Utilities.Interceptors;
using RentAllCars.Core.Utilities.IoC;

namespace RentAllCars.Core.Aspeccts.Autofac.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}
