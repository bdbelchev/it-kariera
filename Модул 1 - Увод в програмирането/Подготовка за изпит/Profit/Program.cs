using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double usdToBgn = double.Parse(Console.ReadLine());

            double monthlySalary = moneyPerDay * workDays;
            double bonus = 2.5 * monthlySalary;
            double yearlySalary = 12 * monthlySalary + bonus;
            double tax = 0.25 * yearlySalary;
            double yearlyIncome = yearlySalary - tax;
            double yearlyIncomeBgn = yearlyIncome * usdToBgn;
            double dailyIncomeBgn = yearlyIncomeBgn / 365;

            Console.WriteLine(Math.Round(dailyIncomeBgn, 2));
        }
    }
}
