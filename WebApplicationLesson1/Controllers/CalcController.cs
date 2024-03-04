using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationLesson1.Controllers
{
    public class CalcController : Controller
    {
        public string Index(double a, double b, char c)
        {
            switch (c)
            {
                case '-':
                    return $"{a} {c} {b} = {a - b}";
                case '*':
                    return $"{a} {c} {b} = {a * b}";
                case '/':
                    return $"{a} {c} {b} = {a / b}";
                default:
                    if (c != '+' && c != 0) return "Пока поддерживаются только операции сложения, вычитания и умножения";
                    return $"{a} + {b} = {a + b}";
            }
        }
    }
}
