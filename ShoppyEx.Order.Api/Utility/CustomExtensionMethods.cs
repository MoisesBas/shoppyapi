
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Options;
using ShoppyEx.SharedKernel.SeedWork;
using System.Net;

namespace ShoppyEx.Order.Api.Utility
{
    public static class CustomExtensionMethods
    {
        public static IServiceCollection AddGrpcServices(this IServiceCollection services)
        {
            #region Product

            services.AddGrpcClient<ProductGrpc.ProductGrpcClient>((services, options) =>
            {
                var catalogApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.GrpcProduct;
                options.Address = new Uri(catalogApi);
            });


            #endregion
            #region Customer
            services.AddGrpcClient<CustomerGrpc.CustomerGrpcClient>((services, options) =>
            {
                var customerApi = services.GetRequiredService<IOptions<UrlsConfig>>().Value.GrpcCustomer;
                options.Address = new Uri(customerApi);
            });
            #endregion

            return services;
        }

        public static IWebHostBuilder AddKestrel(this IWebHostBuilder services, IConfiguration config)
        {
            services.ConfigureKestrel(serverOptions =>
             {
                 var (httpPort, grpcPort) = GetDefinedPorts(config);
                 serverOptions.Listen(IPAddress.Any, httpPort, listenOptions =>
                 {
                     listenOptions.Protocols = HttpProtocols.Http1AndHttp2;

                 });

                 serverOptions.Listen(IPAddress.Any, grpcPort, listenOptions =>
                 {
                     listenOptions.Protocols = HttpProtocols.Http2;
                 });

             });
            return services;
        }
        static (int httpPort, int grpcPort) GetDefinedPorts(IConfiguration config)
        {
            var grpcPort = config.GetValue("GRPC_PORT", 5002);
            var port = config.GetValue("PORT", 81);
            return (port, grpcPort);
        }
    }
}
