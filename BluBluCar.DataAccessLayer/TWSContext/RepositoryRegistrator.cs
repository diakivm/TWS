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
           .AddTransient<IRepository<Trip>, TripRepository>()
           .AddTransient<IRepository<DriverAccount>, DriverAccountRepository>()
           .AddTransient<IRepository<TravelerAccount>, TravelerAccountRepository>()
           .AddTransient<IRepository<Transport>, GenericRepository<Transport>>()
           .AddTransient<IRepository<User>, GenericRepository<User>>()
        ;
    }
}
