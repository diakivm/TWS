using Aplication.DataAccess.Date.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.DataAccessLayer.Date.Repositories;
using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface.Repositories;

namespace TWS.DataAccessLayer.TWSContext
{
    public static class RepositoryRegistrator
    {
        public static IServiceCollection AddRepositoriesInDB(this IServiceCollection services) => services
           .AddTransient<IRepository<DriverAccount>, DriverAccountRepository>()
           .AddTransient<IRepository<User>, UserRepository>()
           .AddTransient<IRepository<Transport>, TransportRepository>()
           .AddTransient<IRepository<TravelerAccount>, TravelerAccountRepository>()
           .AddTransient<IRepository<Trip>, TripRepository>()
        ;
    }
}
