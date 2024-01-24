using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valeter.API.Models
{
    public class Parking
    {
        public int ParkingId { get; set; }
        public string ParkingCode { get; set; }
        public string ParkingName { get; set; }
        public string ParkingDescription { get; set; }
        public string ParkingSpaceNumber { get; set; }
    }
}