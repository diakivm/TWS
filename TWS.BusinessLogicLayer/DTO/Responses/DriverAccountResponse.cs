using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWS.BusinessLogicLayer.DTO.Responses
{
    public class DriverAccountResponse
    {
        public int DriverExperience { get; set; }

        public TransportResponse Transport { get; set; }
        public UserResponse UserAccount { get; set; }
        public IEnumerable<TripResponse> PublishedTrips { get; set; }
    }
}
