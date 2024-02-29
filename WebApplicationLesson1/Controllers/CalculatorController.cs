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
    public class CalculatorController : Controller
    {
        //http://localhost:5000/calculator/index/1/2
        public string Index(int a, int b)
        {
            return $"{a} + {b} = {a + b}";
        }
    }
}
