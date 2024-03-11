using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationLesson1.Controllers
{
    public class StartController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public string Hello()
        {
            DateTime currentTime = DateTime.Now;
            string greeting;
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

            return greeting = $"{timeOfDay}";
        }
    }
}

