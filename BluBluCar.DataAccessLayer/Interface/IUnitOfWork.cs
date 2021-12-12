using Aplication.DataAccess.Interface.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.DataAccessLayer.Interface.Repositories;

namespace TWS.DataAccessLayer.Interface
{
    public interface IUnitOfWork
    {
        ITripRepository TripsRepository { get; }
        ITravelerAccountRepository TravelerAccountRepository { get; }
        IDriverAccountRepository DriverAccountRepository { get; }
        Task SaveChangesAsync();
    }
}
