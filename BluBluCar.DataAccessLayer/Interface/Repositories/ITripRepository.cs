using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface.Repositories;
using TWS.DataAccessLayer.Parameters;

namespace Aplication.DataAccess.Interface.Repositories
{
    public interface ITripRepository : IRepository<Trip>
    {
        Task<IEnumerable<Trip>> GetAsync(TripParameters parameters);
        Task<IEnumerable<Trip>> GetTripsPublishedByDriverAsync(int idDriverAccount);
        Task<IEnumerable<Trip>> GetTripsPlannedByTravelerAsync(int idTravelerAccount);
    }
}
