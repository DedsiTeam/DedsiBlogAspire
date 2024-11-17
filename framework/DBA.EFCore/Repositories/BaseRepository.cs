using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace DBA.EFCore.Repositories;

public interface IBaseRepository<TEntity, in TKey> where TEntity : class
{
    ValueTask<TEntity?> GetAsync(TKey id);

    Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
}

public class BaseRepository<TDbContext, TEntity, TKey>(TDbContext dbContext) : IBaseRepository<TEntity, TKey> where TDbContext : DbContext where TEntity : class
{
    public ValueTask<TEntity?> GetAsync(TKey id)
    {
        return dbContext.Set<TEntity>().FindAsync(id);
    }
    
    public Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
    {
        return dbContext.Set<TEntity>().FirstOrDefaultAsync(predicate, cancellationToken);
    }
}
