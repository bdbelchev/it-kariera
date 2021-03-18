using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.WaterFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int waterTotal = 0;

            for (int i = 0; i < n; i++)
            {
                int waterAmount = int.Parse(Console.ReadLine());

                if (waterAmount + waterTotal <= 255)
                {
                    waterTotal += waterAmount;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(waterTotal);
        }
    }
}
