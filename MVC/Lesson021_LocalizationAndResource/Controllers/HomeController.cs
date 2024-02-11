using Lesson021_LocalizationAndResource.Models;
using Lesson021_LocalizationAndResource;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;
using System.Diagnostics;
using System.Resources;
using System.Reflection;
using Lesson021_LocalizationAndResource;
using Lesson021_LocalizationAndResource.Resources;
using Microsoft.AspNetCore.Localization;

namespace Lesson021_LocalizationAndResource.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //SearchedLocation	"Lesson021_LocalizationAndResource.Resources.Controllers.HomeController"
        private readonly IStringLocalizer<HomeController> _localizer;

        private readonly IHtmlLocalizer<HomeController> _htmllocalizer;
        //private readonly IViewLocalizer<HomeController> _viewlocalizer;

        //SearchedLocation	Lesson021_LocalizationAndResource.Resources.Resources.SharedResource"
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;
        private readonly IStringLocalizer<GlobalResource> _sharedGlobalLocalizer;
        private readonly IStringLocalizer _sharedLocalizer2;
        private readonly GlobalResource _globalResource;

        public HomeController(ILogger<HomeController> logger,
            IStringLocalizer<HomeController> localizer,
            //IHtmlLocalizer<HomeController> htmllocalizer,
            //IViewLocalizer<HomeController> viewlocalizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IStringLocalizer<GlobalResource> sharedGlobalLocalizer,
            IStringLocalizerFactory factory
,
            GlobalResource globalResource

            )
        {
            _logger = logger;
            _localizer = localizer;
            //_htmllocalizer = htmllocalizer;
            //viewlocalizer = _viewlocalizer;
            _sharedLocalizer = sharedLocalizer;
            _sharedGlobalLocalizer = sharedGlobalLocalizer;

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            //_localizer = factory.Create(type);
            _sharedLocalizer2 = factory.Create("SharedResource", assemblyName.Name);
            _globalResource = globalResource;
        }

        public IActionResult Index()
        {
            
            string x = _localizer.GetString( "Hello" ).Value;
            string y = _sharedLocalizer.GetString("Hello").Value;
            string m = _sharedLocalizer2?.GetString("Hello").Value; 
            string t = _sharedGlobalLocalizer.GetString("Hello").Value;
            string k = _globalResource.Get("Hello");
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
        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}
