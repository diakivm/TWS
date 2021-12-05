
using TWS.DataAccessLayer.Entities.Base;
using TWS.DataAccessLayer.Interface.Entity;

namespace TWS.DataAccessLayer.Entities
{
    public class DriverAccount : Entity
    {
        public int DriverExperience { get; set; }

        public int UserAccountForeignKey { get; set; }
        public User UserAccount { get; set; }

        public Transport Transport { get; set; }

        public List<Trip> PublishedTrips { get; set; }

    }
}
