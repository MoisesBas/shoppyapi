


namespace ShoppyEx.Order.Infrastructure.Persistence
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
