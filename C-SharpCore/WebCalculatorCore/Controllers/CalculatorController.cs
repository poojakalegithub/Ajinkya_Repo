using Microsoft.AspNetCore.Mvc;
using WebCalculatorCore.Models;
using CalculatorLibrary;

namespace WebCalculatorCore.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculatorCore c,string calculate)
        {
            if (calculate == "add")
            {
                c.Result = CalculatorFunction.Adition(c.Number1, c.Number2);

            }
            else if (calculate == "subtract")
            {
                c.Result = CalculatorFunction.Subtraction(c.Number1, c.Number2);
            }
            else if (calculate == "multiply")
            {
                c.Result = CalculatorFunction.Multiplication(c.Number1, c.Number2);
            }
            else
            {
                c.Result = CalculatorFunction.Division(c.Number1, c.Number2);
            }
            ViewData["Result"] = c.Result;
            return View();
        }
    }
}
