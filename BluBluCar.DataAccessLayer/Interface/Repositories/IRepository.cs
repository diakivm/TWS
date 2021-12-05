
using TWS.DataAccessLayer.Interface.Entity;

namespace TWS.DataAccessLayer.Interface.Repositories
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        IQueryable<TEntity> GetSet { get; }

        Task<TEntity> GetAsync(int id);

        Task<TEntity> AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(int id);
    }
}
