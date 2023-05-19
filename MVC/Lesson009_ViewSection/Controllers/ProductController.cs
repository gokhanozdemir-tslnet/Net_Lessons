using Microsoft.AspNetCore.Mvc;

namespace Lesson009_ViewSection.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
