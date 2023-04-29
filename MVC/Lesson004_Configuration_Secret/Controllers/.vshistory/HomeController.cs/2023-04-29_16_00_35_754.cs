
using Microsoft.AspNetCore.Mvc;


namespace Lesson004_Configuration.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;


        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {

            ViewBag.MyKey1 = _configuration.GetSection("MyKey").Value ?? "";
            ViewBag.MyKey2 = _configuration["MyKey"] ?? "";
            ViewBag.MyKey3 = _configuration.GetValue<string>("MyKey") ?? "";
            ViewBag.MyKey4 = _configuration.GetValue("MyKey", "");

            return View();
        }
    }
}
