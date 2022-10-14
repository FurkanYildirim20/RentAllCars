using Microsoft.Extensions.DependencyInjection;
using RentAllCars.Core.Utilities.IoC;

namespace RentAllCars.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection service, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(service);
            }

            return ServiceTool.Create(service);
        }
    }
}
