using TWS.DataAccessLayer.Entities;
using Aplication.DataAccess.Interface.Repositories;
using Microsoft.EntityFrameworkCore;
using TWS.DataAccessLayer.TWSContext;

namespace Aplication.DataAccess.Date.Repositories
{
    public class TripsRepository : GenericRepository<Trip>, ITripsRepository
    {
        public TripsRepository(TWSDBContext databaseContext)
            : base(databaseContext)
        {
        }

        public async Task<IEnumerable<Trip>> GetTripsPlannedByTravelerAsync(int idTravelerAccount)
        {
            return await this._table.Where(t => t.TravelerAccountForeignKey == idTravelerAccount)
                               .Include(t => t.TravelerAccount)
                               .ThenInclude(u => u.UserAccount)
                               .ToListAsync();
        }

        public async Task<IEnumerable<Trip>> GetTripsPublishedByDriverAsync(int idDriverAccount)
        {
            return await this._table.Where(t => t.DriverAccountForeignKey == idDriverAccount)
                               .Include(d => d.DriverAccount)
                               .ThenInclude(u => u.UserAccount)
                               .ToListAsync();
        }

    }
}
