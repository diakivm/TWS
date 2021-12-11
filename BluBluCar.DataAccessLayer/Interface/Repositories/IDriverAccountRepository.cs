using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.DataAccessLayer.Entities;

namespace TWS.DataAccessLayer.Interface.Repositories
{
    public interface IDriverAccountRepository : IRepository<DriverAccount>
    {
        Task<IEnumerable<DriverAccount>> GetDriverAccountsByDrivingExperienceAsync(double drivingExperience);
        Task<IEnumerable<DriverAccount>> GetDriverAccountsByCarBrandAsync(string carBrand);
        Task<IEnumerable<DriverAccount>> GetDriverAccountsBySeetsOfCarAsync(int neededFreeSeets);
        Task<DriverAccount> GetDriverAccountByTripAsync(Trip trip);
    }
}
