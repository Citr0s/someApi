using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SomeApi.Models;

namespace SomeApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            var person = new Person
            {
                Name = "Milosz",
                DateOfBirth = new DateTime(1996, 10, 10)
            };
            return JsonConvert.SerializeObject(person);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}