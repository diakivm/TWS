using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWS.BusinessLogicLayer.DTO.Responses
{
    public class TransportResponse
    {
        public int Id { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int NumberOfSeats { get; set; }
    }
}
