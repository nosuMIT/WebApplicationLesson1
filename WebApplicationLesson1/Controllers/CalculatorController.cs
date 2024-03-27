using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLesson1.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int a = 0, int b = 0, string c = "+")
        {
            switch (c)
            {
                case "+":
                    return $"{a} + {b} = {a + b}";
                case "-":
                    return $"{a} - {b} = {a - b}";
                case "*":
                    return $"{a} * {b} = {a * b}";
                case "/":
                    return $"{a} / {b} = {a / b}";
                default:
                    return "Invalid operation";
            }
        }
    }
}
