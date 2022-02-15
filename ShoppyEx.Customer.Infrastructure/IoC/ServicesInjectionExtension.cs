using Microsoft.Extensions.DependencyInjection;
using ShoppyEx.Customer.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.EventSourcing;

namespace ShoppyEx.Customer.Infrastructure.IoC
{
    public static class ServicesInjectionExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));           
            services.AddScoped<ICustomerUnitOfWork, CustomerUnitOfWork>();
            services.AddSingleton<IEventSerializer, EventSerializer>();
        }
    }
}
