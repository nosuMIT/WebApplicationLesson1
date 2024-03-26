using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLesson1.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int a, int b, string c = "+")
        {
            switch (c)
            {
                case "+":
                    return $"{a} + {b} = {a + b}";
                case "-":
                    return $"{a} - {b} = {a - b}";
                case "*":
                    return $"{a} * {b} = {a * b}";
            }
            return "Invalid operation";
        }
    }
}
