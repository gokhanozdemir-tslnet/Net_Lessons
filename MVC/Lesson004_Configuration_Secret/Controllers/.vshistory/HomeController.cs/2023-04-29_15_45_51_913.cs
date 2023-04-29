using Lesson004_Configuration.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Lesson004_Configuration.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;


        public HomeController(IConfiguration configuration
                            )
        {

        }

        public IActionResult Index()
        {



            return View();
        }
    }
}
