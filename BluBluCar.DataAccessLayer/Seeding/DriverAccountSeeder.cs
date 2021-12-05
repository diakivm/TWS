using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TWS.DataAccessLayer.Seeding
{
    class DriverAccountSeeder : ISeeder<DriverAccount>
    {
        private static readonly List<DriverAccount> driverAccounts = new List<DriverAccount>()
        {
            new DriverAccount()
            {
                Id = 1,
                DriverExperience = 20,
                UserAccountForeignKey = 1
            },
            new DriverAccount()
            {
                Id = 2,
                DriverExperience = 5,
                UserAccountForeignKey = 2
            }
        };

        public void Seed(EntityTypeBuilder<DriverAccount> builder) => builder.HasData(driverAccounts);
    }
}
