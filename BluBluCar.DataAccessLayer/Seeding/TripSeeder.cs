using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TWS.DataAccessLayer.Seeding
{
    class TripSeeder : ISeeder<Trip>
    {
        private static readonly List<Trip> trips = new List<Trip>()
        {
            new Trip()
            {
                Id = 1,
                PlaceOfDeparture = "Chernivtsi",
                PlaceOfArrival = "Lviv",
                TimeOfDeparture = DateTime.Now,
                TimeOfArrival = DateTime.Now.AddHours(3),
                NumberOfFreeSeats = 1,
                DriverAccountForeignKey = 1,
                TravelerAccountForeignKey = 1
            },
            new Trip()
            {
                Id = 2,
                PlaceOfDeparture = "Lviv",
                PlaceOfArrival = "Ivano-Frankivsk",
                TimeOfDeparture = DateTime.Now.AddDays(2),
                TimeOfArrival = DateTime.Now.AddDays(2).AddHours(3),
                NumberOfFreeSeats = 3,
                DriverAccountForeignKey = 1
            },
            new Trip()
            {
                Id = 3,
                PlaceOfDeparture = "Odessa",
                PlaceOfArrival = "Kyiw",
                TimeOfDeparture = DateTime.Now.AddDays(1),
                TimeOfArrival = DateTime.Now.AddDays(2),
                NumberOfFreeSeats = 3,
                DriverAccountForeignKey = 2
            },
        };

        public void Seed(EntityTypeBuilder<Trip> builder) => builder.HasData(trips);
    }
}
