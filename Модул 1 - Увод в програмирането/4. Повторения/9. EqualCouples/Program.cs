using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.EqualCouples
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int previousSum = 0;
            int difference = 0;

            for (int i = 0; i < n; i++)
            {
                if (i != 0)
                {
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    int currentSum = num1 + num2;
                    if (Math.Abs(currentSum - previousSum) > difference)
                    {
                        difference = Math.Abs(currentSum - previousSum);
                    }

                    previousSum = currentSum;
                }
                else
                {
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    previousSum = num1 + num2;
                }
            }

            Console.WriteLine(difference == 0 ? $"Yes, value={previousSum}" : $"No, maxdiff={difference}");
        }
    }
}
