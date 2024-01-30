using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valeter.API.Models
{
    public class JobService
    {
        public int JobServiceTypeId { get; set; }
        public string JobServiceTypeCode { get; set; }
        public string JobServiceTypeName { get; set; }
        public string JobServiceTypeDescription { get; set; }
        public int JobServiceTypeDuration { get; set; }
        public float JobServiceTypePrice { get; set; }
    }
}