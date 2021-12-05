


using TWS.DataAccessLayer.Date;
using TWS.DataAccessLayer.Interface;
using TWS.DataAccessLayer.TWSContext;

using Microsoft.EntityFrameworkCore;
using Aplication.DataAccess.Date.Repositories;
using TWS.DataAccessLayer.Date.Repositories;
using TWS.DataAccessLayer.Interface.Entity;
using TWS.DataAccessLayer.Entities;

var optionsBuilder = new DbContextOptionsBuilder<TWSDBContext>();

var options = optionsBuilder.UseSqlServer("Server=DESKTOP-U45QJ4E\\SQLEXPRESS;Database=TWSDataBase;Trusted_Connection=True;").Options;


using (var db = new TWSDBContext(options))
{

    IUnitOfWork unitOfWork = new UnitOfWork(db, new TripsRepository(db), new TravelerAccountRepository(db), new DriverAccountRepository(db));


    var tripsPublishedByDrivers = unitOfWork.TripsRepository.GetTripsPublishedByDriverAsync(1);

    foreach (var item in tripsPublishedByDrivers.Result)
        Console.WriteLine($"{item.PlaceOfDeparture} {item.PlaceOfArrival}");

    Console.WriteLine("==============================================================");

    var tripsPlanedByTraveler = unitOfWork.TripsRepository.GetTripsPlannedByTravelerAsync(1);

    foreach (var item in tripsPlanedByTraveler.Result)
        Console.WriteLine($"{item.PlaceOfDeparture} {item.PlaceOfArrival}");

    Console.WriteLine("==============================================================");

    var asd = unitOfWork.DriverAccountRepository.GetDriverAccountsBySeets(2);

    foreach (var item in asd.Result)
        Console.WriteLine($"{item.DriverExperience} {item.UserAccount?.FirstName} {item.Transport.CarBrand}");

}