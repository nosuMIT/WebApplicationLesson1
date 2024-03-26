using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplicationLesson1.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            if (DateTime.Now.Hour < 6)
                return "Доброй ночи!";
            if (DateTime.Now.Hour < 12)
                return "Доброе утро!";
            if (DateTime.Now.Hour < 18)
                return "Добрый день!";
        
            return "Добрый вечер!";
        }
    }
}
