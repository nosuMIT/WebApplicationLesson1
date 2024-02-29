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

        public string DetermineTheTime()
        {

            DateTime currentTime = DateTime.Now;

            string timeOfDay;
            if (currentTime.Hour >= 0 && currentTime.Hour < 6)
            {
                timeOfDay = "Доброй ночи";
            }
            else if (currentTime.Hour >= 6 && currentTime.Hour < 12)
            {
                timeOfDay = "Доброе утро";
            }
            else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
            {
                timeOfDay = "Добрый день";
            }
            else
            {
                timeOfDay = "Добрый вечер";
            }

            string greeting = $"{timeOfDay}";
        }

            /*  switch (time)
                {
                    case 1: (time.Hour > 0.00 && time.Hour < 6.00)
                        return "Доброй ночи";
                    case 2: (time.Hour >= 6.00 && time.Hour < 12.00)
                        return "Доброе утро";
                    case 4: (time.Hour >= 12.00 && time.Hour < 18.00)
                        return "Добрый вечер";

                    default: return "Добрый день";
                }


            public string Hello()
            {

                return $"{time }";
            }
                */

            /*[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
