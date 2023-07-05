using Microsoft.AspNetCore.Mvc;

namespace Lesson018_AreasAndIdentity.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
