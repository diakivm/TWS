using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWS.BusinessLogicLayer.DTO.Responses
{
    public class TravelerAccountResponse
    {
        public int TravelExperience { get; set; }

        public UserResponse UserAccount { get; set; }
        public IEnumerable<TripResponse> PlannedTrips { get; set; }
    }
}
