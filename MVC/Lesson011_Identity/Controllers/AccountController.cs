using Microsoft.AspNetCore.Mvc;

namespace Lesson011_Identity.Controllers
{
    public class AccountController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
