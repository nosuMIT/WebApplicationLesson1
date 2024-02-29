﻿using Microsoft.AspNetCore.Mvc;
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

        /*public IActionResult Index()
        {
            return View();
        }*/

        public string Calc(int a, int b)
        {
            //return "<a href='Home/Index'>This is a link to a Index page</a>";
            //return "This is a new page for our ASP project";
            //return (id * 10) + " " + name;

            //return (a + b).ToString();
            return $"{a} + {b} = {a+b}";
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
