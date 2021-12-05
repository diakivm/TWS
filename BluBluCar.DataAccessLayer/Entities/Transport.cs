
using TWS.DataAccessLayer.Entities.Base;

namespace TWS.DataAccessLayer.Entities
{
    public class Transport : Entity
    {
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int NumberOfSeats { get; set; }

        public int DriverAccountForeignKey { get; set; }
        public DriverAccount DriverAccount { get; set; }
    }
}
