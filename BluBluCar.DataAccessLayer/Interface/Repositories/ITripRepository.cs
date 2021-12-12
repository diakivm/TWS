using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface.Repositories;

namespace Aplication.DataAccess.Interface.Repositories
{
    public interface ITripRepository : IRepository<Trip>
    {    
        Task<IEnumerable<Trip>> GetTripsPublishedByDriverAsync(int idDriverAccount);
        Task<IEnumerable<Trip>> GetTripsPlannedByTravelerAsync(int idTravelerAccount);
    }
}
