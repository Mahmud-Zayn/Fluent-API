using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAPIAndValidation.Core.Domain;
using FluentAPIAndValidation.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace FLuentAPIAndValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ValuesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Customers>> Get()
        {
            var customers = _context.Customers.ToList();
            return customers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            return Ok();
         }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) { }
    }
}