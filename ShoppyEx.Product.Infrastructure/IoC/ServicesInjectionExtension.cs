using Microsoft.Extensions.DependencyInjection;
using ShoppyEx.Product.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.EventSourcing;

namespace ShoppyEx.Product.Infrastructure.IoC
{
    public static class ServicesInjectionExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));           
            services.AddScoped<IProductUnitOfWork, ProductUnitOfWork>();
            services.AddSingleton<IEventSerializer, EventSerializer>();
        }
    }
}
