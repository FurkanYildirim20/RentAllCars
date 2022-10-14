using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using RentAllCars.Core.CrossCuttingConcern.Caching;
using RentAllCars.Core.CrossCuttingConcern.Caching.Microsoft;
using RentAllCars.Core.Utilities.IoC;
using System.Diagnostics;

namespace RentAllCars.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<Stopwatch>();

        }
    }
}
