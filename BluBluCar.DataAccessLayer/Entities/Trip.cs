
using TWS.DataAccessLayer.Entities.Base;

namespace TWS.DataAccessLayer.Entities
{
    public class Trip : Entity
    {
        public string PlaceOfDeparture { get; set; }
        public string PlaceOfArrival { get; set; }
        public DateTime TimeOfDeparture { get; set; }
        public DateTime TimeOfArrival { get; set; }
        public byte NumberOfFreeSeats { get; set; }
        
        public int? DriverAccountForeignKey { get; set; } 
        public DriverAccount DriverAccount { get; set; }

        public int? TravelerAccountForeignKey { get; set; }  //https://docs.microsoft.com/ru-ru/ef/core/saving/cascade-delete
        public TravelerAccount TravelerAccount  { get; set; }
    }
}
