using Microsoft.AspNetCore.Mvc;

namespace Lesson004_Configuration.Configurations
{
    public class HomeController : Controller
    {
        private IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
