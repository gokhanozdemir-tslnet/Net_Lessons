using Lesson010_HttpClient.Models;
using Lesson010_HttpClient.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson010_HttpClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyService _myService;

        public HomeController(ILogger<HomeController> logger, MyService myService)
        {
            _logger = logger;
            _myService = myService;
        }

        public IActionResult Index()
        {
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