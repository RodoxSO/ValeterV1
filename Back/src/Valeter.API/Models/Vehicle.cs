using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valeter.API.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string VehicleReg { get; set; }
        public string VehiclePrivReg { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleColor { get; set; }

        public string VehicleManufacturerId { get; set; }
        public virtual VehicleManufacturer VehicleManufacturer { get; set; }
        public int VehicleTypeId { get; set; }
        public virtual VehicleType VehicleType { get; set; }
    }
}