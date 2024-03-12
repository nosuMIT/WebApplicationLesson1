using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationLesson1.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a, double b, string operation)
        {
            switch (operation)
            {
                case "*":
                    return $"{a} * {b} = {a * b}";
                case "-":
                    return $"{a} - {b} = {a - b}";
                case "+":
                    return $"{a} + {b} = {a + b}";
                default:
                    if (operation != null)
                    {
                        return "не решу, операция непонятная";
                    }
                    return $"{a} + {b} = {a + b}";
            }
        }
    }
}