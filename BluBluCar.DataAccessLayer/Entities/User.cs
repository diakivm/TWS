
using TWS.DataAccessLayer.Entities.Base;

namespace TWS.DataAccessLayer.Entities
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }

        public DriverAccount DriverAccount { get; set; }

        public TravelerAccount TravelerAccount { get; set; }
    }
}
