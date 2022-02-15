using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyEx.SharedKernel.SeedWork.Extensions
{
    public static class Configurations
    {
        public static int Run<TContext>(this IServiceProvider hostBuilder, bool isDropDatabase = false)
            where TContext:DbContext
        {
            try
            {
                hostBuilder
                    .MigrateDbContext<TContext>(isDropDatabase);                   
                return 0;
            }
            catch (Exception ex)
            {
                return 1;
            }
            finally
            {

            }
        }
    }
}
