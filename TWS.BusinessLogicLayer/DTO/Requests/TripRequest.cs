using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.BusinessLogicLayer.DTO.Responses;

namespace TWS.BusinessLogicLayer.DTO.Requests
{
    public class TripRequest
    {
        public int Id { get; set; }
        public string PlaceOfDeparture { get; set; }
        public string PlaceOfArrival { get; set; }
        public DateTime TimeOfDeparture { get; set; }
        public DateTime TimeOfArrival { get; set; }
        public byte NumberOfFreeSeats { get; set; }
    }
}
