using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationLesson1.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a, double b, char operation)
        {
            char[] appropriateOperations = { '-', '+', '*' };
            switch (operation)
            {
                case '-':
                    return $"{a} {operation} {b} = {a - b}";
                case '*':
                    return $"{a} {operation} {b} = {a * b}";
                default:
                    if(operation != '+' && operation != 0) return "Пока поддерживаются только операции сложения, вычитания и умножения";
                    return $"{a} + {b} = {a + b}";
            }
        }
    }
}
