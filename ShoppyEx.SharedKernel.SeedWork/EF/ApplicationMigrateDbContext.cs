using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ShoppyEx.SharedKernel.SeedWork
{
    public static class Migrate
    {
        public static IServiceProvider MigrateDbContext<TContext>(
          this IServiceProvider host, bool drop)
            where TContext : DbContext
        {
            using (var scope = host.CreateScope())
            {
                var services = scope.ServiceProvider;
                var logger = services.GetRequiredService<ILogger<TContext>>();
                var context = services.GetRequiredService<TContext>();

                try
                {
                    logger.LogInformation($"Migrating database associated with context {typeof(TContext).Name}");
                    if (context != null)
                    {                        
                       if(drop) context.Database.EnsureDeleted();
                       context.Database.Migrate();                       
                      
                      
                    }

                    logger.LogInformation($"Migrated database associated with context {typeof(TContext).Name}");
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, $"An error occurred while migrating the database used on context {typeof(TContext).Name}");
                }
            }

            return host;
        }
    }
}
