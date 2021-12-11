using TWS.DataAccessLayer.Entities;
using Aplication.DataAccess.Interface.Repositories;
using Microsoft.EntityFrameworkCore;
using TWS.DataAccessLayer.TWSContext;
using TWS.DataAccessLayer.Parameters;

namespace Aplication.DataAccess.Date.Repositories
{
    public class TripsRepository : GenericRepository<Trip>, ITripsRepository
    {
        public TripsRepository(TWSDBContext databaseContext)
            : base(databaseContext)
        {
        }

        public async Task<IEnumerable<Trip>> GetTripsByParametersAsync(TripParameters parameters)
        {
            return await this._table.Where(t => t.PlaceOfDeparture == parameters.PlaceOfDeparture && t.PlaceOfArrival == parameters.PlaceOfArrival)
                                    .ToListAsync();
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
