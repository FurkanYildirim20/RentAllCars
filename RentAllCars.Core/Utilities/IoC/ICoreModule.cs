using Microsoft.Extensions.DependencyInjection;

namespace RentAllCars.Core.Utilities.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
