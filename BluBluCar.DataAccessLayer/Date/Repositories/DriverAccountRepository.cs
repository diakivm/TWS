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
    public class DriverAccountRepository : GenericRepository<DriverAccount>, IDriverAccountRepository
    {
        public DriverAccountRepository(TWSDBContext dbContext) 
          : base(dbContext)
        {
        }

        public async Task<IEnumerable<DriverAccount>> GetDriverAccountsByDrivingExperienceAsync(double drivingExperience)
        {
            return await this._table.Where(d => d.DriverExperience >= drivingExperience)
                                    .Include(u => u.UserAccount)
                                    .Include(c => c.Transport)
                                    .Include(t => t.PublishedTrips)
                                    .ToListAsync();
        }

        public async Task<IEnumerable<DriverAccount>> GetDriverAccountsByCarBrandAsync(string carBrand)
        {

            return await this._table.Where(c => c.Transport.CarBrand == carBrand)
                                    .Include(u => u.UserAccount)
                                    .Include(c => c.Transport)
                                    .ToListAsync();
        }

        public async Task<IEnumerable<DriverAccount>> GetDriverAccountsBySeetsOfCarAsync(int neededFreeSeets)
        {
            return await this._table.Where(t => t.Transport.NumberOfSeats >= neededFreeSeets)
                                    .Include(t => t.Transport)
                                    .Include(u => u.UserAccount)
                                    .ToListAsync();
        }

        public async Task<DriverAccount> GetDriverAccountByTripAsync(Trip trip)
        {
            return await this._table.Where(d => d.PublishedTrips.Contains(trip))
                                   .Include(u => u.UserAccount)
                                   .Include(t => t.Transport)
                                   .Include(t => t.PublishedTrips)
                                   .FirstOrDefaultAsync();
        }
    }
}
