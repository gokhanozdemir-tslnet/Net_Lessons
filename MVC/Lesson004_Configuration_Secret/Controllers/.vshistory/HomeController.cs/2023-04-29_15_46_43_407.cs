
using Microsoft.AspNetCore.Mvc;


namespace Lesson004_Configuration.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;


        public HomeController(IConfiguration configuration)
        {

        }

        public IActionResult Index()
        {



            return View();
        }
    }
}
