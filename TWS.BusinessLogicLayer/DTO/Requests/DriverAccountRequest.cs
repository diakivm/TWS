using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWS.BusinessLogicLayer.DTO.Requests
{
    public class DriverAccountRequest
    {
        public int Id { get; set; }
        public int DriverExperience { get; set; }

        public IEnumerable<TripRequest> PublishedTrips { get; set; }
    }
}
