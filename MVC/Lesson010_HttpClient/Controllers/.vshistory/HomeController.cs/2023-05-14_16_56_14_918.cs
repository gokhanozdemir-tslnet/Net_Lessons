using Lesson010_HttpClient.Models;
using Lesson010_HttpClient.SericeContracts;
using Lesson010_HttpClient.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson010_HttpClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITodoService _myService;

        public HomeController(ILogger<HomeController> logger, ITodoService myService)
        {


            _logger = logger;
            _myService = myService;
        }

        public IActionResult Index()
        {
            var x = _myService.GetTodos("1");
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