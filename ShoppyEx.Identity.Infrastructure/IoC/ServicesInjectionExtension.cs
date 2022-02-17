using Microsoft.Extensions.DependencyInjection;
using ShoppyEx.SharedKernel.SeedWork.EventSourcing;

namespace ShoppyEx.Identity.Infrastructure.IoC
{
    public static class ServicesInjectionExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));          
         
            services.AddSingleton<IEventSerializer, EventSerializer>();
           
        }
    }
}
