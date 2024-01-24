using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valeter.API.Models
{
    public class WashingStatus
    {
        public int WashingStatusId { get; set; }
        public string WashingStatusCode { get; set; }
        public string WashingStatusName { get; set; }
        public string WashingStatusDescription { get; set; }
    }
}