using Microsoft.Extensions.Configuration;
using System.IO;

namespace ShoppyEx.SharedKernel.SeedWork.Extensions
{
    public static class ConfigurationHelper
    {
        public static IConfiguration GetConfiguration(string? basePath = null)
        {
            basePath ??= Directory.GetCurrentDirectory();
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json");

            return builder.Build();
        }
    }
}
