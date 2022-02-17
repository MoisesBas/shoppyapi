using Microsoft.Extensions.Options;
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Identity.Api.Utility
{
    public static class CustomExtensionMethods
    {
        public static IServiceCollection AddGrpcServices(this IServiceCollection services)
        {

            services.AddGrpcClient<CustomerGrpc.CustomerGrpcClient>((services, options) =>
            {
                var customerApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.GrpcCustomer;
                options.Address = new Uri(customerApi);
            });
            return services;
        }
    }
}
