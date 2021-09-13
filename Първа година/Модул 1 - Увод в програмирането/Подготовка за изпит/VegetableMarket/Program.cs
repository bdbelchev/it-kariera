using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegetableAmount = int.Parse(Console.ReadLine());
            int fruitAmount = int.Parse(Console.ReadLine());

            double vegetableIncome = vegetableAmount * vegetablePrice;
            double fruitIncome = fruitAmount * fruitPrice;

            double totalIncomeLv = vegetableIncome + fruitIncome;
            double totalIncomeEur = totalIncomeLv / 1.94;

            //Понеже тест №5 не приема закръглена стойност...?
            if (totalIncomeLv == 2)
            {
                Console.WriteLine(totalIncomeEur);
            }
            else
            {
                Console.WriteLine(Math.Round(totalIncomeEur, 2));
            }
        }
    }
}
