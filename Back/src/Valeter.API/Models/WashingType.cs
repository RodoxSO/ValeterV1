using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valeter.API.Models
{
    public class WashingType
    {
        public int WashingTypeId { get; set; }
        public string WashingTypeCode { get; set; }
        public string WashingTypeName { get; set; }
        public string WashingTypeDescription { get; set; }
        public int WashingTypeTime { get; set; }
        public float WashingTypePrice { get; set; }
    }
}