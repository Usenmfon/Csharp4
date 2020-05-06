using Microsoft.AspNetCore.Mvc;
using System;

namespace CalculatorApp.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public ActionResult Squareroot()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Squareroot(string firstNumber, string secondNumber)
        {
            try{
            double numberOne = double.Parse(firstNumber);
            double numberTwo = double.Parse(secondNumber);
            double fNumberSqrt = Math.Sqrt(numberOne);
            double sNumberSqrt = Math.Sqrt(numberTwo);
            ViewBag.NumberOne = numberOne;
            ViewBag.NumberTwo = numberTwo;
            ViewBag.FNumberSqrt = fNumberSqrt;
            ViewBag.SNumberSqrt = sNumberSqrt;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View();
        }
    }
}
