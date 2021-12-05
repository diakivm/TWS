using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TWS.DataAccessLayer.Seeding
{
    class UserSeeder : ISeeder<User>
    {
        private static readonly List<User> users = new List<User>()
        {
            new User()
            {
                Id = 1,
                FirstName = "Chris",
                LastName = "Evans",
                DateOfBirth = new DateTime(1971, 08, 23),
                Gender = "male",
                PhoneNumber = "+380965433214",
            },
            new User()
            {
                Id = 2,
                FirstName = "Johny",
                LastName = "Depp",
                DateOfBirth = new DateTime(1978, 09, 16),
                Gender = "male",
                PhoneNumber = "+380965433463",
            },
            new User()
            {
                Id = 3,
                FirstName = "Will",
                LastName = "Smith",
                DateOfBirth = new DateTime(1969, 03, 25),
                Gender = "male",
                PhoneNumber = "+380965437645",
            },
             new User()
            {
                Id = 4,
                FirstName = "Robert",
                LastName = "Downey",
                DateOfBirth = new DateTime(1969, 01, 12),
                Gender = "male",
                PhoneNumber = "+380965433421",
            },
              new User()
            {
                Id = 5,
                FirstName = "Keanu",
                LastName = "Reevs",
                DateOfBirth = new DateTime(1985, 04, 13),
                Gender = "male",
                PhoneNumber = "+380965454374",
            },
        };

        public void Seed(EntityTypeBuilder<User> builder) => builder.HasData(users);
    }
}
