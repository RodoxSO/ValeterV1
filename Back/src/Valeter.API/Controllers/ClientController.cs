using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Valeter.API.Data;
using Valeter.API.Models;

namespace Valeter.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        public IEnumerable<Client> _client = new Client[] {
            new Client() {
                ClientId = 1,
                ClientName = "Cliente 1",
                ClientLocation = "Location 1",
                ClientAddressLine1 = "Address Line 1",
                ClientAddressLine2 = "Address Line 2",
                ClientAddressNumber = "123",
                ClientTown = "Bristol",
                ClientPostalCode = "BS00 0AA",
                ClientCountry = 1,
                ClientPhone = "11111-11111",
                ClientEmail = "email@email.com",
                LogoUrl = "URL Logo",
                CompanyId = 1 
            },
            new Client() {
                ClientId = 2,
                ClientName = "Cliente 2",
                ClientLocation = "Location 2",
                ClientAddressLine1 = "Address Line 1",
                ClientAddressLine2 = "Address Line 2",
                ClientAddressNumber = "321",
                ClientTown = "Bristol",
                ClientPostalCode = "BS00 0BB",
                ClientCountry = 1,
                ClientPhone = "22222-11111",
                ClientEmail = "email2@email.com",
                LogoUrl = "URL Logo 2",
                CompanyId = 2
            }
        };

        private readonly DataContext _context;

        public ClientController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public string Post()
        {
            return "Teste de Post";
        }

        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _context.Clients;
        }

        [HttpGet("{id}")]
        public IEnumerable<Client> GetById(int id)
        {
            return _context.Clients.Where(client => client.ClientId == id);
        }

        [HttpPut("id")]
        public string Put(int id)
        {
            return $"Teste Put com id = {id}";
        }

        [HttpDelete("id")]
        public string Delete(int id)
        {
            return "Teste Delete com id = " + id;
        }
    }
}