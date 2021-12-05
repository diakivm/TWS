using Microsoft.EntityFrameworkCore;
using TWS.DataAccessLayer.Entities.Base;
using TWS.DataAccessLayer.Interface.Repositories;
using TWS.DataAccessLayer.TWSContext;

namespace Aplication.DataAccess.Date.Repositories
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly TWSDBContext _dbContext;
        protected readonly DbSet<TEntity> _table;

        public bool AutoSaveChanges { get; set; } = true;

        public GenericRepository(TWSDBContext dbContext)
        {
            this._dbContext = dbContext;
            this._table = this._dbContext.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> GetSet => this._table;

        public async Task<TEntity> GetAsync(int id) => await GetSet.SingleOrDefaultAsync(i => i.Id == id);

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
              _dbContext.Entry(entity).State = EntityState.Added;
            if (AutoSaveChanges)
                await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync(TEntity entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
              _dbContext.Entry(entity).State = EntityState.Modified;
            if (AutoSaveChanges)
                await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _dbContext.Remove(new TEntity { Id = id });
            if (AutoSaveChanges)
                await _dbContext.SaveChangesAsync();
        }
    }
}
    