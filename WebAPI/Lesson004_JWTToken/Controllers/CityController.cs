using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson004_JWTToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {


        public CityController() { }

        [HttpGet]
        public async Task<ActionResult<List<string>>> Get()
        {
            var cities = new List<string> { "London, İstanbul, Tokyo, NewYork, Berlin" };
            return cities;
        }
    }
}
