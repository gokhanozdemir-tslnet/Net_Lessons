using Lesson013_Cookie.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson013_Cookie.Controllers
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

            //read cookie
            ViewBag.cookieKey = "myCookieKey";
            ViewBag.cookieValue = Request.Cookies["myCookieKey"] ?? "";

            return View();
        }

        public IActionResult Privacy()
        {
            //create cookie
            Response.Cookies.Append("myCookieKey","myCookieValue"+DateTime.Now.ToString(),
                new CookieOptions
                {
                    Expires = DateTime.Now.AddMinutes(1),
                    HttpOnly = true,
                    SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict
                });

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}