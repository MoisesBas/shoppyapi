using Microsoft.EntityFrameworkCore;

namespace ShoppyEx.SharedKernel.SeedWork
{
    public abstract class UnitOfWork<TDbContext> : IUnitOfWork
     where TDbContext : DbContext
    {
        protected readonly TDbContext DbContext;
       

        protected UnitOfWork(TDbContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<bool> CommitAsync(CancellationToken cancellationToken)
        {
            try
            {
                await StoreEvents(cancellationToken);
                return await DbContext.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (Exception ex)
            { 
            }
            return false;
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
           return DbContext.Set<TEntity>();
        }

        protected abstract Task StoreEvents(CancellationToken cancellationToken);
    }
}
