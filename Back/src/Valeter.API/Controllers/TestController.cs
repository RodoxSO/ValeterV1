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
    public class TestController : ControllerBase
    {
        private readonly DataContext _context;

        public TestController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public string Post()
        {
            return "Teste de Post";
        }

        [HttpGet]
        public IEnumerable<Test> Get()
        {
            return _context.Tests;
        }

        [HttpGet("{id}")]
        public Test GetById(int id)
        {
            return _context.Tests.FirstOrDefault(client => client.TestId == id);
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