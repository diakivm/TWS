﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TWS;
using TWS.BusinessLogicLayer.Data;
using TWS.BusinessLogicLayer.Registration;
using TWS.Data;
using TWS.DataAccessLayer.TWSContext;

namespace BluBluCar
{
    public partial class App : Application
    {

        private static IHost __Host;

        public static IHost Host => __Host
            ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        public static IServiceProvider Services => Host.Services;

        internal static void ConfigureServices(HostBuilderContext host, IServiceCollection services) => services
           .AddDatabase(host.Configuration.GetSection("Database"))
           .AddMapper()
           .AddServices()
        ;

        protected override async void OnStartup(StartupEventArgs e)
        {

            var host = Host;

            using (var scope = Services.CreateScope())
                scope.ServiceProvider.GetRequiredService<DbInitializer>().InitializeAsync().Wait();

            base.OnStartup(e);
            await host.StartAsync();
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            using var host = Host;
            base.OnExit(e);
            await host.StopAsync();
        }
    }
}
