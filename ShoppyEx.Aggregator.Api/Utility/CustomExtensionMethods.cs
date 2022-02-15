using Microsoft.Extensions.Options;
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Aggregator.Api.Utility
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

            services.AddGrpcClient<ProductGrpc.ProductGrpcClient>((services, options) =>
            {
                var catalogApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.GrpcProduct;
                options.Address = new Uri(catalogApi);
            });

            services.AddGrpcClient<CategoryGrpc.CategoryGrpcClient>((services, options) =>
            {
                var categoryApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.GrpcProduct;
                options.Address = new Uri(categoryApi);
            });
            services.AddGrpcClient<TagGrpc.TagGrpcClient>((services, options) =>
            {
                var tagApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.GrpcProduct;
                options.Address = new Uri(tagApi);
            });

            services.AddGrpcClient<OrderGrpc.OrderGrpcClient>((services, options) =>
            {
                var tagApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.GrpcOrder;
                options.Address = new Uri(tagApi);
            });

            return services;
        }
    }
}
