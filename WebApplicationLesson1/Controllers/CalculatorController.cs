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
        public string Index(int a, int b, char c)
        {
            if (c == '+')
            {
                return $"{a} + {b} = {a + b}";
            }
            if (c == '*')
            {
                return $"{a} * {b} = {a * b}";
            }
            if (c == '-')
            {
                return $"{a} - {b} = {a - b}";
            }
            if (c == '\0')
            {
                return $"{a} + {b} = {a + b}";
            }
            return $"0 + 0 = 0";
        }
        //комментарий для гита
    }
}
