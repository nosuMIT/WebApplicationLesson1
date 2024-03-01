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
    public class CalcController : Controller
    {
        public string Index(double a, double b, char c)
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
            if (c == '/')
            {
                return $"{a} / {b} = {a / b}";
            }
            if (c != '*' && c != '+' && c != '-' && c != '/')
            {
                return $"Введите пример, как указано здесь: https://localhost:5001/calc/index?a=4&b=5&c=*";
            }
            return $"0 + 0 = 0";
            
        }
    }
}
