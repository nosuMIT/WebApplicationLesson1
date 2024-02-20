using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplicationLesson1.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            int time = DateTime.Now.Hour;
            if (time >= 0 && time < 6) return "Доброй ночи";
            else if (time >= 6 && time < 12) return "Доброе утро";
            else if (time >= 12 && time <18) return "Добрый день";
            else if (time >= 18 && time < 0) return "Добрый вечер";
            return DateTime.Now.ToString();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
