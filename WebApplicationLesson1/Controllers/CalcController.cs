using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLesson1.Controllers
{
    public class CalcController : Controller
    {
        public string Index(double a, double b, string c)
        {
            if (c == "*") return $"{a} * {b} = {a * b}";
            else if (c == "-") return $"{a} - {b} = {a - b}";
            else if (c == "+") return $"{a} + {b} = {a + b}";
            else if (c == "/") return $"{a} / {b} = {a / b}";
            else if (c != null) return "Пожалуйста, введите одну из операций: *, -, +. Либо нее вводите операцию, чтобы получить сумму чисел.";
            return $"{a} + {b} = {a + b}";
        }
    }
}
