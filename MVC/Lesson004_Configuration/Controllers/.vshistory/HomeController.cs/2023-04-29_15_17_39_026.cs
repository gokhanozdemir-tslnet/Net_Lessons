using Lesson004_Configuration.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Lesson004_Configuration.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly MasterKey _masterKeysConf;


        public HomeController(IConfiguration configuration,
                              IOptions<MasterKey> masterKeysConf)
        {
            _configuration = configuration;
            _masterKeysConf = masterKeysConf.Value;
        }

        public IActionResult Index()
        {
            ViewBag.MyKey1 = _configuration.GetSection("MyKey").Value ?? "";
            ViewBag.MyKey2 = _configuration["MyKey"] ?? "";
            ViewBag.MyKey3 = _configuration.GetValue<string>("MyKey") ?? "";
            ViewBag.MyKey4 = _configuration.GetValue("MyKey", "");


            ViewBag.MasterKey1 = _configuration.GetSection("MasterKey")["Key1"] ?? "";
            ViewBag.MasterKey2 = _configuration.GetSection("MasterKey")["Key2"] ?? "";
            ViewBag.MasterKey3 = _configuration.GetSection("MasterKey")["Key3"] ?? "";

            ViewBag.MasterKeyConf = _masterKeysConf;
            _masterKeysConf.

            return View();
        }
    }
}
