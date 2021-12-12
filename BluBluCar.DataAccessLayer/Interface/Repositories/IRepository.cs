
using TWS.DataAccessLayer.Interface.Entity;

namespace TWS.DataAccessLayer.Interface.Repositories
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {

        Task<IEnumerable<TEntity>> GetAsync();

        Task<TEntity> GetByIdAsync(int id);

        Task AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(int id);
    }
}
