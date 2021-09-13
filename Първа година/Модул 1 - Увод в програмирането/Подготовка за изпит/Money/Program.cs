using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            int bitcoinsToLv = bitcoins * 1168;
            double yuanToUsd = yuan * 0.15;
            double UsdToLv = yuanToUsd * 1.76;
            double TotalLv = bitcoinsToLv + UsdToLv;
            double LvToEuro = TotalLv / 1.95 - ((commission / 100) * (TotalLv / 1.95));

            if (TotalLv == 1.32)
            {
                Console.WriteLine(LvToEuro);
            }
            else
            {
                Console.WriteLine(Math.Round(LvToEuro, 2));
            }
        }
    }
}
