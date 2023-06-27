using Lesson015_Caching.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;
using System.Collections.Generic;

namespace Lesson015_Caching.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache _cache;
        private const string exampleListCacheKey = "exampleListCacheKey";

        public HomeController(ILogger<HomeController> logger,
            IMemoryCache cache)
        {
            _logger = logger;
            _cache = cache;
        }

        public IActionResult Index()
        {
            IEnumerable<Example>? data;

            if(!_cache.TryGetValue<IEnumerable<Example>>(exampleListCacheKey,out data))
            {
                data = new List<Example>();
                for (int i = 0; i < 10000000; i++)
                {
                    (data  as List<Example>).Add(new Example { Id = i, Name = $"name{i}" });
                }

                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                    .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                    .SetPriority(CacheItemPriority.Normal)
                    .SetSize(1024);

                _cache.Set<IEnumerable<Example>>(
                    exampleListCacheKey,
                    data,
                    cacheEntryOptions
                    );
            }
            

          

            return View(data.Take(5));
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