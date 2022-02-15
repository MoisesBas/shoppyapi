using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace ShoppyEx.SharedKernel.SeedWork;

public interface IUnitOfWork
{
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    Task<bool> CommitAsync(CancellationToken cancellationToken = default(CancellationToken));
}