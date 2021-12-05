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
        Task<IEnumerable<DriverAccount>> GetDriverAccountsByDrivingExperience(double drivingExperience);
        Task<IEnumerable<DriverAccount>> GetDriverAccountsByCarBrand(string carBrand);
        Task<IEnumerable<DriverAccount>> GetDriverAccountsBySeetsOfCar(int neededFreeSeets);
        Task<IEnumerable<DriverAccount>> GetAllTripOfDriverAccount(int idDrivingAccount);
    }
}
