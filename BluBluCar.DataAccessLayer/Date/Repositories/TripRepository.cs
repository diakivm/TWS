using TWS.DataAccessLayer.Entities;
using Aplication.DataAccess.Interface.Repositories;
using Microsoft.EntityFrameworkCore;
using TWS.DataAccessLayer.TWSContext;
using TWS.DataAccessLayer.Exceptions;
using TWS.DataAccessLayer.Parameters;

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

        public async Task<IEnumerable<Trip>> GetAsync(TripParameters parameters)
        {
            IQueryable<Trip> source = _table.Include(d => d.DriverAccount)
                                            .Include(t => t.TravelerAccount);

            SearchByPlaceOfDeparture(ref source, parameters.PlaceOfDeparture);
            SearchByPlaceOfArrival(ref source, parameters.PlaceOfArrival);
            SearchByTimeOfDeparture(ref source, parameters.TimeOfDeparture);
            SearchByTimeOfArrival(ref source, parameters.TimeOfArrival);
            SearchByNeededFreeSeats(ref source, parameters.NumberOfFNeededSeats);

            return await source.ToListAsync();
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




        public void SearchByPlaceOfDeparture(ref IQueryable<Trip> source, string PlaceOfDeparture)
        {
            if (string.IsNullOrWhiteSpace(PlaceOfDeparture))
                return;

            source = source.Where(p => p.PlaceOfDeparture == PlaceOfDeparture);
        }

        public void SearchByPlaceOfArrival(ref IQueryable<Trip> source, string PlaceOfArrival)
        {
            if (string.IsNullOrWhiteSpace(PlaceOfArrival))
                return;

            source = source.Where(p => p.PlaceOfArrival == PlaceOfArrival);
        }

        public void SearchByTimeOfArrival(ref IQueryable<Trip> source, DateTime TimeOfArrival)
        {
            if (TimeOfArrival.Day < DateTime.Now.Day)
                return;

            source = source.Where(p => p.TimeOfArrival <= TimeOfArrival);
        }

        public void SearchByTimeOfDeparture(ref IQueryable<Trip> source, DateTime TimeOfDeparture)
        {
            if (TimeOfDeparture.Day < DateTime.Now.Day)
                return;

            source = source.Where(p => p.TimeOfDeparture >= TimeOfDeparture);
        }

        public void SearchByNeededFreeSeats(ref IQueryable<Trip> source, int NeededFreeSeats)
        {
            if (NeededFreeSeats <=0)
                return;

            source = source.Where(p => p.NumberOfFreeSeats >= NeededFreeSeats);
        }
    }
}
