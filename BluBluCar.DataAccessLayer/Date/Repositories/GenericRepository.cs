using Microsoft.EntityFrameworkCore;
using TWS.DataAccessLayer.Entities.Base;
using TWS.DataAccessLayer.Exceptions;
using TWS.DataAccessLayer.Interface.Repositories;
using TWS.DataAccessLayer.TWSContext;

namespace Aplication.DataAccess.Date.Repositories
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly TWSDBContext _dbContext;
        protected readonly DbSet<TEntity> _table;


        public GenericRepository(TWSDBContext dbContext)
        {
            this._dbContext = dbContext;
            this._table = this._dbContext.Set<TEntity>();
        }

        public abstract Task<TEntity> GetCompleteEntityAsync(int id);

        public virtual async Task<IEnumerable<TEntity>> GetAsync() => await _table.ToListAsync();

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await _table.FindAsync(id)
                ?? throw new EntityNotFoundException(
                    GetEntityNotFoundErrorMessage(id));
        }

        public virtual async Task AddAsync(TEntity entity) => await _table.AddAsync(entity);

        public virtual async Task UpdateAsync(TEntity entity) =>
            await Task.Run(() => _table.Update(entity));

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            await Task.Run(() => _table.Remove(entity));
        }

        protected static string GetEntityNotFoundErrorMessage(int id) =>
            $"{typeof(TEntity).Name} with id {id} not found.";
    }
}
    