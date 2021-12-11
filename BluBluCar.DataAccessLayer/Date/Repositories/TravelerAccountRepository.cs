using Aplication.DataAccess.Date.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface.Repositories;
using TWS.DataAccessLayer.TWSContext;

namespace TWS.DataAccessLayer.Date.Repositories
{
    public class TravelerAccountRepository : GenericRepository<TravelerAccount>, ITravelerAccountRepository
    {
        public TravelerAccountRepository(TWSDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<TravelerAccount>> GetTravelersAccountByTripAsync(Trip trip)
        {
            return await this._table.Where(p => p.PlannedTrips.Contains(trip))
                                    .Include(u => u.UserAccount)
                                    .ToListAsync();
        }
    }
}
