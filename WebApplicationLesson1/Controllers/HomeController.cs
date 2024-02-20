using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationLesson1.Models;

namespace WebApplicationLesson1.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        DateTime time = new DateTime();
        public string DetermineTheTime()
        {
            switch (time)
            {
                case 1: (time.Hour > 0.00 && time.Hour < 6.00)
                    return "Доброй ночи";
                case 2: (time.Hour >= 6.00 && time.Hour < 12.00)
                    return "Доброе утро";
                case 4: (time.Hour >= 12.00 && time.Hour < 18.00)
                    return "Добрый вечер";

                default: return "Добрый день";
            }
                
        }
        public string Hello()
        {

            return $"{time }";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
