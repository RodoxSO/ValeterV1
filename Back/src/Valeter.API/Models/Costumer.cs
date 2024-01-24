using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valeter.API.Models
{
    public class Costumer
    {
        public int CostumerId { get; set; }
        public string CostumerName { get; set; }
        public string CostumerPhone { get; set; }
        public string CostumerEmail { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}