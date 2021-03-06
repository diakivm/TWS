using Aplication.DataAccess.Interface.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.DataAccessLayer.Interface;
using TWS.DataAccessLayer.Interface.Repositories;
using TWS.DataAccessLayer.TWSContext;

namespace TWS.DataAccessLayer.Date
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly TWSDBContext context;

        public ITripRepository TripsRepository { get;}
        public ITravelerAccountRepository TravelerAccountRepository { get;}
        public IDriverAccountRepository DriverAccountRepository { get;}
        public IUserRepository UserRepository { get; }

        public async Task SaveChangesAsync() => await context.SaveChangesAsync();

        public UnitOfWork(TWSDBContext context, ITripRepository tripsRepository, ITravelerAccountRepository travelerAccountRepository, IDriverAccountRepository driverAccountRepository, IUserRepository userRepository)
        {
            this.context = context;
            this.TripsRepository = tripsRepository;
            this.TravelerAccountRepository = travelerAccountRepository;
            this.DriverAccountRepository = driverAccountRepository;
            this.UserRepository = userRepository;
        }
        
    }
}
