using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valeter.API.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public int JobTypeId { get; set; }
        public int CostumerId { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public int VehicleId { get; set; }
        public DateTime TimeBook { get; set; }
        public DateTime TimeCollect { get; set; }
        public DateTime TimeStart {  get; set; }
        public DateTime TimeFinish { get; set; }
        public DateTime Duration { get; set; }
        public DateTime DtCreation { get; set; }
    }
}