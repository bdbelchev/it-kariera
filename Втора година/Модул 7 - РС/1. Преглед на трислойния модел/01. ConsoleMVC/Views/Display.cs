using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._ConsoleMVC.Views
{
    class Display
    {
        public decimal Percent { get; set; }
        public decimal Amount { get; set; }
        public decimal Total { get; set; }
        public decimal TipAmount { get; set; }

        public Display()
        {
            Percent = 0;
            Amount = 0;
            Total = 0;
            TipAmount = 0;
            GetValues();
        }

        private void GetValues()
        {
            Console.WriteLine("Enter the amount of the meal:");
            Amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percent you want to tip:");
            Percent = decimal.Parse(Console.ReadLine());
        }

        public void ShowTipAndTotal()
        {
            Console.WriteLine($"Your tip is: {TipAmount:C}");
            Console.WriteLine($"Your total will be: {Total:C}");
        }
    }
}
