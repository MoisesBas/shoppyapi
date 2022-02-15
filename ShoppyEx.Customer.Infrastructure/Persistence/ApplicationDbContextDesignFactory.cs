using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ShoppyEx.SharedKernel.SeedWork.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyEx.Customer.Infrastructure.Persistence
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
