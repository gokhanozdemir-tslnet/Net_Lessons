using Lesson003_Autofac.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson003_Autofac.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public ISingleton singleton1 { get; set; }
        public ISingleton singleton2 { get; set; }
        public ISingleton singleton3 { get; set; }

        public ITransient transient1 { get; set; }
        public ITransient transient2 { get; set; }
        public ITransient transient3 { get; set; }

        public IScope scope1 { get; set; }
        public IScope scope2 { get; set; }
        public IScope scope3 { get; set; }

        public HomeController(ILogger<HomeController> logger,
            ISingleton singleton1, ISingleton singleton2, ISingleton singleton3,
            ITransient transient1, ITransient transient2, ITransient transient3,
            IScope scope1, IScope scope2, IScope scope3)
        {
            _logger = logger;
            this.singleton1 = singleton1;
            this.singleton2 = singleton2;
            this.singleton3 = singleton3;
            this.transient1 = transient1;
            this.transient2 = transient2;
            this.transient3 = transient3;
            this.scope1 = scope1;
            this.scope2 = scope2;
            this.scope3 = scope3;
        }

        public IActionResult Index()
        {
            var result = new DepInjResult();
            result.Singleton1 = singleton1;
            result.Singleton2 = singleton2;
            result.Singleton3 = singleton3;
            result.Transient1 = transient1;
            result.Transient2 = transient2;
            result.Transient3 = transient3;
            result.Scope1 = scope1;
            result.Scope2 = scope2;
            result.Scope3 = scope3;
            return View(result);
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