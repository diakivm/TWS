
using TWS.DataAccessLayer.Entities.Base;

namespace TWS.DataAccessLayer.Entities
{
    public class TravelerAccount : Entity
    {
        public int TravelExperience { get; set; }

        public int UserAccountForeignKey { get; set; }
        public User UserAccount { get; set; }

        public List<Trip> PlannedTrips { get; set; }

    }
}
