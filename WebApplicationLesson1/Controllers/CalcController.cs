using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationLesson1.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a, double b, string c)
        {
            switch (c)
            {
                case "*":
                    return $"{a} * {b} = {a * b}";
                case "-":
                    return $"{a} - {b} = {a - b}";
                case "+":
                    return $"{a} + {b} = {a + b}";
                case "/":
                    if (b != 0)
                        return $"{a} / {b} = {a / b}";
                    else
                        return "деление на ноль";
                default:
                    if (c != null)
                        return "непонятная операция";
                    return $"{a} + {b} = {a + b}";
            }
        }
    }
}