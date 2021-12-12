using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.DataAccessLayer.Entities;

namespace TWS.DataAccessLayer.Interface.Repositories
{
    public interface ITravelerAccountRepository : IRepository<TravelerAccount>
    {
        Task<IEnumerable<TravelerAccount>> GetTravelersAccountByTripAsync(int id);
    }
}
