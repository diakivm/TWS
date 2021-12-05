using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TWS.DataAccessLayer.Seeding
{
    class TravelerAccountSeeder : ISeeder<TravelerAccount>
    {
        private static readonly List<TravelerAccount> travelerAccounts = new List<TravelerAccount>()
        {
            new TravelerAccount()
            {
                Id = 1,
                TravelExperience = 3,
                UserAccountForeignKey = 3,
            },
            new TravelerAccount()
            {
                Id = 2,
                TravelExperience = 7,
                UserAccountForeignKey = 4,
            }
        };
        public void Seed(EntityTypeBuilder<TravelerAccount> builder) => builder.HasData(travelerAccounts);
    }
}
