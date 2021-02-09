using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double wMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toys = 0;
            int savings = 0;
            int birthdayMoney = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savings += (birthdayMoney - 1);
                    birthdayMoney += 10;
                }
                else
                {
                    toys++;
                }
            }

            savings += (toys * toyPrice);

            Console.WriteLine(savings >= wMachinePrice
                ? $"Yes! {savings - wMachinePrice:f2}"
                : $"No! {wMachinePrice - savings:f2}");
        }
    }
}
