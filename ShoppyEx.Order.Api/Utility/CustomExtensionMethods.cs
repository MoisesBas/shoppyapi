
using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Net;

namespace ShoppyEx.Order.Api.Utility
{
    public static class CustomExtensionMethods
    {
        public static IServiceCollection AddGrpcServices(this IServiceCollection services)
        {         

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
