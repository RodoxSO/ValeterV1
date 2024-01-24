using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valeter.API.Models
{
    public class Client
    {
        public int ClientId { get; set; }
         public string ClientName { get; set; }
        public string ClientLocation { get; set; }
        public string ClientAddressLine1 { get; set; }
        public string ClientAddressLine2 { get; set; }
        public string ClientAddressNumber { get; set; }
        public string ClientTown { get; set; }
        public string ClientPostalCode { get; set; }
        public int ClientCountry { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }
        public string LogoUrl { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        List<Costumer> Costumers { get; set; }
    }
}