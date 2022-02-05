using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TipCalculatorWeb.Models;

namespace TipCalculatorWeb.Controllers
{
    public class TipCalculatorController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateTip(decimal amount, decimal percent)
        {
            Tip tip = new Tip(amount, percent);

            return View("Index", tip);
        }
    }
}
