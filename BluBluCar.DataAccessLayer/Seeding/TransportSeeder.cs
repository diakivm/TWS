using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TWS.DataAccessLayer.Seeding
{
    class TransportSeeder : ISeeder<Transport>
    {
        private static List<Transport> transports = new List<Transport>()
        {
            new Transport()
            {
                Id = 1,
                CarBrand = "BMW",
                CarModel = "X5",
                NumberOfSeats = 3,
                DriverAccountForeignKey = 1
            },
            new Transport()
            {
                Id = 2,
                CarBrand = "Audi",
                CarModel = "A7",
                NumberOfSeats = 3,
                DriverAccountForeignKey = 2
            }
        };

        public void Seed(EntityTypeBuilder<Transport> builder) => builder.HasData(transports);
    }
}
