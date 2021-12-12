using TWS.DataAccessLayer.Entities;
using Aplication.DataAccess.Interface.Repositories;
using Microsoft.EntityFrameworkCore;
using TWS.DataAccessLayer.TWSContext;
using TWS.DataAccessLayer.Exceptions;

namespace Aplication.DataAccess.Date.Repositories
{
    public class TripRepository : GenericRepository<Trip>, ITripRepository
    {
        public TripRepository(TWSDBContext databaseContext)
            : base(databaseContext)
        {
        }

        public override async Task<Trip> GetCompleteEntityAsync(int id)
        {
            var trip = await this._table.Include(d => d.DriverAccount)
                                        .ThenInclude(u => u.UserAccount)
                                        .Include(t => t.TravelerAccount)
                                        .ThenInclude(u => u.UserAccount)
                                        .SingleOrDefaultAsync(t => t.Id == id);

            return trip ?? throw new EntityNotFoundException(GetEntityNotFoundErrorMessage(id));
        }

        public async Task<IEnumerable<Trip>> GetTripsPlannedByTravelerAsync(int idTravelerAccount)
        {
            return await this._table.Where(t => t.TravelerAccountForeignKey == idTravelerAccount)
                               .ToListAsync();
        }

        public async Task<IEnumerable<Trip>> GetTripsPublishedByDriverAsync(int idDriverAccount)
        {
            return await this._table.Where(t => t.DriverAccountForeignKey == idDriverAccount)
                               .ToListAsync();
        }


    }
}
