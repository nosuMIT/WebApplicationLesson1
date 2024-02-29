using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLesson1.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double num1, double num2, string operation)
        {

            if (operation == "*") return $"{num1} * {num2} = {num1 * num2}";
            else if (operation == "-") return $"{num1} - {num2} = {num1 - num2}";
            else if (operation == "+") return $"{num1} + {num2} = {num1 + num2}";
            else if (operation != null) return "Пожалуйста, введите одну из операций: *, -, +. Либо нее вводите операцию, чтобы получить сумму чисел.";
            return $"{num1} + {num2} = {num1 + num2}";
        }
    }
}
