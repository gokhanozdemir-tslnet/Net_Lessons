﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Lesson004_Configuration.Configurations
{
    public class HomeController : Controller
    {
        private IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.MyKey1 = _configuration.GetSection("MyKey").Value ?? "";
            ViewBag.MyKey1 = _configuration["MyKey"] ?? "";
            ViewBag.MyKey1 = _configuration.GetValue<string>("MyKey") ?? "";
            ViewBag.MyKey1 = _configuration.GetValue<string>("MyKey", "");


            return View();
        }
    }
}
