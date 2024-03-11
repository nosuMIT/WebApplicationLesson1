using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationLesson1.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: /<controller>/
        public double Index(double a, double b)
        {
            return a + b;
        }
    }
}

