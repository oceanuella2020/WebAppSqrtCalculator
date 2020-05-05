using System;
using Microsoft.AspNetCore.Mvc;

namespace WebAppSqrtCalculator.Controllers
{
    public class CalcuController:Controller
    {
        [HttpGet]
        public ActionResult Sqrt()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sqrt(string firstNumber,string secondNumber)
        {
            int numberOne=int.Parse(firstNumber);
            int numberTwo=int.Parse(secondNumber);
            double result=Math.Sqrt(numberOne);
            double result2=Math.Sqrt(numberTwo);
            ViewBag.result=result;
            ViewBag.result2=result2;
            ViewBag.numberOne=firstNumber;
            ViewBag.numberTwo=secondNumber;
            
            return View();
        }
    }
}