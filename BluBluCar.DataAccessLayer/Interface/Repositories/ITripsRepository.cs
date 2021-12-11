using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface.Repositories;
using TWS.DataAccessLayer.Parameters;

namespace Aplication.DataAccess.Interface.Repositories
{
    public interface ITripsRepository : IRepository<Trip>
    {    
        Task<IEnumerable<Trip>> GetTripsPublishedByDriverAsync(int idDriverAccount);
        Task<IEnumerable<Trip>> GetTripsPlannedByTravelerAsync(int idTravelerAccount);
        Task<IEnumerable<Trip>> GetTripsByParametersAsync(TripParameters parameters);

    }
}
