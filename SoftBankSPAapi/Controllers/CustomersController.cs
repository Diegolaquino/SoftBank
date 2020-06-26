using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SoftBankSPAapi.Models;

namespace SoftBankSPAapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly AppDBContext _database;
        public CustomersController(AppDBContext database)
        {
            _database = database;
        }
        // GET: api/<CustomersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomersController>
        [HttpPost]
        public async Task<ActionResult<dynamic>> Post([FromBody] Customer customer)
        {
            await _database.Customers.AddAsync(customer);

            await _database.SaveChangesAsync();

            return new
            {
                name = customer.Name
            };
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
