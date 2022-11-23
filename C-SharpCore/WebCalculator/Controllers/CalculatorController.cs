using System.Web.Mvc;
using WebCalculator.Models;
using CalculatorLibrary;

namespace WebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new Calculator());
        }

        [HttpPost]
        public ActionResult Index(Calculator c,string calculate)
        {
           if(calculate == "add")
            { 
                c.Result= CalculatorFunction.Adition(c.Number1,c.Number2);
                
            }
            else if (calculate == "subtract")
            {
                c.Result = CalculatorFunction.Subtraction(c.Number1, c.Number2);
            }
            else if (calculate == "multiply")
            {
                c.Result = CalculatorFunction.Multiplication(c.Number1, c.Number2);
            }
            else if (calculate == "divide")
            {
                c.Result = CalculatorFunction.Division(c.Number1, c.Number2);
            }

            return View(c);
        }
    }
}