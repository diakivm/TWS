using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.BusinessLogicLayer.Interfaces.Services;
using TWS.BusinessLogicLayer.Services;

namespace TWS.BusinessLogicLayer.Registration
{
    public static class ServicesRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
          .AddTransient<ITripService, TripService>()
          .AddTransient<IDriverAccountService, DriverAccountService>()
          .AddTransient<ITravelerAccountService, TravelerAccountService>()
       ;
    }
}
