using Microsoft.AspNetCore.Mvc;

namespace Lesson004_Configuration.Configurations
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
