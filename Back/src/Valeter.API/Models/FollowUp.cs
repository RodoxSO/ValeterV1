using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valeter.API.Models
{
    public class FollowUp
    {
        public int FollowUpId { get; set; }
        public DateTime FollowUpDate { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public string FollowUpDescription { get; set; }
    }
}