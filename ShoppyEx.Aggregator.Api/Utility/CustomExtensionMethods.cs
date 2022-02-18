using Microsoft.Extensions.Options;

namespace ShoppyEx.Aggregator.Api.Utility
{
    public static class CustomExtensionMethods
    {
        public static IServiceCollection AddGrpcServices(this IServiceCollection services)
        {
            #region Customer
            services.AddGrpcClient<CustomerGrpc.CustomerGrpcClient>((services, options) =>
            {
                var customerApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.GrpcCustomer;
                options.Address = new Uri(customerApi);
            });
            #endregion
            #region Product

            services.AddGrpcClient<ProductGrpc.ProductGrpcClient>((services, options) =>
            {
                var catalogApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.GrpcProduct;
                options.Address = new Uri(catalogApi);
            });

            services.AddGrpcClient<ProductBrandGrpc.ProductBrandGrpcClient>((services, options) =>
            {
                var categoryApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.GrpcProduct;
                options.Address = new Uri(categoryApi);
            });

            services.AddGrpcClient<ProductTypeGrpc.ProductTypeGrpcClient>((services, options) =>
            {
                var tagApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.GrpcProduct;
                options.Address = new Uri(tagApi);
            });
            #endregion
            #region Order

            services.AddGrpcClient<OrderGrpc.OrderGrpcClient>((services, options) =>
            {
                var tagApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.GrpcOrder;
                options.Address = new Uri(tagApi);
            });

            services.AddGrpcClient<BasketGrpc.BasketGrpcClient>((services, options) =>
            {
                var tagApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.GrpcOrder;
                options.Address = new Uri(tagApi);
            });

            #endregion
            #region Identiy
            services.AddGrpcClient<UserGrpc.UserGrpcClient>((services, options) =>
            {
                var tagApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.GrpcIdentity;
                options.Address = new Uri(tagApi);
            });
            #endregion

            return services;
        }
    }
}
