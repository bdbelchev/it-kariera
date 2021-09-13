using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());

            double moneySpent = 0;
            double age = 18;

            for (int year = 1800; year <= yearToLive; year++)
            {
                if (year % 2 == 0)
                {
                    moneySpent += 12000;
                    age++;
                }
                else
                {
                    moneySpent += 12000 + 50 * age;
                    age++;
                }
            }

            double moneyLeft = inheritance - moneySpent;
            Console.WriteLine(moneyLeft < 0
                ? $"He will need {Math.Abs(moneyLeft):f2} dollars to survive."
                : $"Yes! He will live a carefree life and will have {moneyLeft:f2} dollars left.");
        }
    }
}
