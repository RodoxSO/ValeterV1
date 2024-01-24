using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valeter.API.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyAddressNumber { get; set; }
        public string CompanyCity { get; set;}
        public string CompanyRegion { get; set;}
        public string CompanyPostalCode { get; set;}
        public string CompanyCountry { get; set;}
        public string CompanyPhone { get; set;}
        public string CompanyEmail { get; set; }
        public string LogoUrl { get; set; }
        public List<Client> Clients { get; set; }
    }
}