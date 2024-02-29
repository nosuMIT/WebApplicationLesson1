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
    public class StartController : Controller
    {
        //http://localhost:5000/start/hello
        public string Hello()
        {
            DateTime timeOfDay = DateTime.Now;
            if (timeOfDay.Hour >= 0 && timeOfDay.Hour <= 5)
            {
                if (timeOfDay.Minute <= 59)
                {
                    return $"Доброй ночи";
                }
            }
            if (timeOfDay.Hour >= 6 && timeOfDay.Hour <= 11)
            {
                if (timeOfDay.Minute <= 59)
                {
                    return $"Доброе утро";
                }
            }
            if (timeOfDay.Hour >= 12 && timeOfDay.Hour <= 17)
            {
                if (timeOfDay.Minute <= 59)
                {
                    return $"Добрый день";
                }
            }
            if (timeOfDay.Hour >= 18 && timeOfDay.Hour <= 23)
            {
                if (timeOfDay.Hour <= 59)
                {
                    return $"Добрый вечер";
                }
            }
            return $"Ифы закончились";
        }


        //http://localhost:5000/start/hello?name=OleG&age=20
    }
}
