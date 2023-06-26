using Lesson002_UsingEFCore.Data;
using Lesson002_UsingEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson002_UsingEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        // GET: api/<CityController>
        //[HttpGet]
        //public  IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        private readonly WAPILesson002DbContext _context;

        public CityController(WAPILesson002DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>?> Get()
        {
            if (!_context.Cities.Any())
            {
                var cities = new List<City>
            {
                        new City {  CityName = "CityName1" },
                        new City {  CityName = "CityName2" },
                        new City {  CityName = "CityName3" },
                        new City {  CityName = "CityName4" }
                };
                _context.AddRange(cities);
                _context.SaveChanges();
            }

            return await _context.Cities.ToListAsync();

        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
