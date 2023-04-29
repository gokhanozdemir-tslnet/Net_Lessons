using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

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
            ViewBag.MyKey1 = _configuration.GetSection("MyKey").Value ?? "";
            ViewBag.MyKey2 = _configuration["MyKey"] ?? "";
            ViewBag.MyKey3 = _configuration.GetValue<string>("MyKey") ?? "";
            ViewBag.MyKey4 = _configuration.GetValue<string>("MyKey", "");


            ViewBag.MasterKey1 = _configuration.GetSection("MasterKey")["Key1"] ?? "";
            ViewBag.MasterKey2 = _configuration.GetSection("MasterKey")["Key2"] ?? "";
            ViewBag.MasterKey3 = _configuration.GetSection("MasterKey")["Key3"] ?? "";

            return View();
        }
    }
}
