using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWS.BusinessLogicLayer.DTO.Responses
{
    public class TripResponse
    {
        public string PlaceOfDeparture { get; set; }
        public string PlaceOfArrival { get; set; }
        public DateTime TimeOfDeparture { get; set; }
        public DateTime TimeOfArrival { get; set; }
        public byte NumberOfFreeSeats { get; set; }

        public DriverAccountResponse DriverAccount { get;set; }
    }
}
