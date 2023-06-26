using Lesson014_Session.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson014_Session.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            if (HttpContext.Session.GetString("mysession")==null)
            {
                HttpContext.Session.SetString("mysession", $"Session value: {DateTime.Now.ToString()}");
            }else
            {
                ViewBag.sessionValue = HttpContext.Session.GetString("mysession");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}