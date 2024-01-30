using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valeter.API.Models
{
    public class JobStatus
    {
        public int JobStatusId { get; set; }
        public string JobStatusCode { get; set; }
        public string JobStatusName { get; set; }
        public string JobStatusDescription { get; set; }
    }
}