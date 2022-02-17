


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ShoppyEx.SharedKernel.SeedWork.Extensions;

namespace ShoppyEx.Identity.Infrastructure.Persistence
{
   
    public class ApplicationDbContextDesignFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var connString = ConfigurationHelper.GetConfiguration(AppContext.BaseDirectory)
                ?.GetConnectionString("DefaultConnection");
            
            return new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(connString ?? throw new InvalidOperationException(),
                               sqlOptions =>
                                {
                                    sqlOptions.MigrationsAssembly(GetType().Assembly.FullName);
                                }
                   ).Options);

        }
    }
}
