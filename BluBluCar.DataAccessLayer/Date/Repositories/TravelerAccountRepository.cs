using Aplication.DataAccess.Date.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Exceptions;
using TWS.DataAccessLayer.Interface.Repositories;
using TWS.DataAccessLayer.TWSContext;

namespace TWS.DataAccessLayer.Date.Repositories
{
    public class TravelerAccountRepository : GenericRepository<TravelerAccount>, ITravelerAccountRepository
    {
        public TravelerAccountRepository(TWSDBContext dbContext) : base(dbContext)
        {
        }

        public override async Task<TravelerAccount> GetCompleteEntityAsync(int id)
        {
            var traveler = await this._table.Include(u => u.UserAccount)
                                            .Include(t => t.PlannedTrips)
                                            .SingleOrDefaultAsync(t => t.Id == id);
            return traveler ?? throw new EntityNotFoundException(GetEntityNotFoundErrorMessage(id));
        }

        public async Task<IEnumerable<TravelerAccount>> GetTravelersAccountByTripAsync(int id)
        {
            return await this._table.Where(p => p.PlannedTrips.Any(t => t.Id == id))
                                    .Include(u => u.UserAccount)
                                    .ToListAsync();
        }
    }
}
