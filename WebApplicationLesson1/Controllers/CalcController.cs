using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationLesson1.Controllers
{
    public class CalcController : Controller
    {
        // GET: /<controller>/
        public string Index(double a,double b,char c)
        {
            switch (c)
            {
                case '-':
                    return $"{a} {c} {b}= {a - b}";
                case '*':
                    return $"{a} {c} {b}= {a * b}";
                case '/':
                    return $"{a} {c} {b} = {a / b}";
                default:
                    if (c != '+' && c != 0) return "Операция не поддерживается";
                    return $"{a} {c} {b} = {a + b}";
            }
        }
    }
}

