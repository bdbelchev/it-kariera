using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SumOfTheOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggestSoFar = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    biggestSoFar = currentNumber;
                    sum += currentNumber;
                }
                else
                {
                    if (currentNumber > biggestSoFar)
                    {
                        biggestSoFar = currentNumber;
                    }

                    sum += currentNumber;
                }
            }

            int sumWithoutBiggest = sum - biggestSoFar;
            if (sumWithoutBiggest == biggestSoFar)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithoutBiggest}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumWithoutBiggest - biggestSoFar)}");
            }
        }
    }
}
