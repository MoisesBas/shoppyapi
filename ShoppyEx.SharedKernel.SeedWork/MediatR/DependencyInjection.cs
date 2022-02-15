using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace ShoppyEx.SharedKernel.SeedWork.MediatR
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomMediatR<TType>(this IServiceCollection services,
            Action<IServiceCollection> doMoreActions = null)
        {
            services.AddMediatR(typeof(TType));  
            doMoreActions?.Invoke(services);

            return services;
        }
    }
}
