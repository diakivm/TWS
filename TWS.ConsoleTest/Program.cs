


using TWS.DataAccessLayer.Date;
using TWS.DataAccessLayer.Interface;
using TWS.DataAccessLayer.TWSContext;

using Microsoft.EntityFrameworkCore;
using Aplication.DataAccess.Date.Repositories;
using TWS.DataAccessLayer.Date.Repositories;
using TWS.DataAccessLayer.Interface.Entity;
using TWS.DataAccessLayer.Entities;
using TWS.BusinessLogicLayer.Services;
using TWS.BusinessLogicLayer.Configuration;
using AutoMapper;

var optionsBuilder = new DbContextOptionsBuilder<TWSDBContext>();

var options = optionsBuilder.UseSqlServer("Server=DESKTOP-U45QJ4E\\SQLEXPRESS;Database=TWSDataBase;Trusted_Connection=True;").Options;


using (var db = new TWSDBContext(options))
{

    IUnitOfWork unitOfWork = new UnitOfWork(db, new TripRepository(db), new TravelerAccountRepository(db), new DriverAccountRepository(db), new UserRepository(db));

    unitOfWork.TripsRepository.DeleteAsync(1);

    await Task.Delay(1000);

    var tripsPublishedByDrivers = unitOfWork.TripsRepository.GetTripsPublishedByDriverAsync(1);

    foreach (var item in tripsPublishedByDrivers.Result)
        Console.WriteLine($"{item.PlaceOfDeparture} {item.PlaceOfArrival} {item.Id}");


    /*
       Console.WriteLine("==============================================================");

       var tripsPlanedByTraveler = unitOfWork.TripsRepository.GetTripsPlannedByTravelerAsync(1);

       foreach (var item in tripsPlanedByTraveler.Result)
           Console.WriteLine($"{item.PlaceOfDeparture} {item.PlaceOfArrival}");

       Console.WriteLine("==============================================================");

       var asd = unitOfWork.DriverAccountRepository.GetDriverAccountsBySeetsOfCarAsync(2);

       foreach (var item in asd.Result)
           Console.WriteLine($"{item.DriverExperience} {item.UserAccount.FirstName} {item.Transport.CarBrand}");
    */
}