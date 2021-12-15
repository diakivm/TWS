using TWS.BusinessLogicLayer.DTO.Requests;

namespace TWS.BusinessLogicLayer.DTO.Responses
{
    public class TravelerAccountRequest
    {
        public int Id { get; set; }
        public int TravelExperience { get; set; }

        public IEnumerable<TripRequest> PlannedTrips { get; set; }
    }
}
