
namespace ShoppyEx.Order.Infrastructure.Persistence
{
    public sealed class ApplicationDbContext: DbContext
    {      
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
         
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<DomainEvent>();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
