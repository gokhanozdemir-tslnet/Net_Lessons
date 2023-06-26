
using Lesson003_UsingSwagger.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson003_UsingSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        /// <summary>
        /// This methods brings api active person list
        /// </summary>
        /// <returns>
        /// Preson List
        /// </returns>
        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<List<Person>>> Get()
        {
            var persons = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                persons.Add(new Person { PersonId=i, Name="Name"+i.ToString(),Surname="Surname"+i.ToString()});
            }
            return persons;
        }
    }

}
