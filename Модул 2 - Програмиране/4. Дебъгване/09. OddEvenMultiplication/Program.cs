using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.OddEvenMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvensAndOdds(int i)
        {
            int oddSum = SumOdd(i);
            int evenSum = SumEven(i);

            return oddSum * evenSum;
        }

        private static int SumEven(int i)
        {
            int sum = 0;

            while (i > 0)
            {
                if (i % 10 % 2 == 0)
                {
                    sum += i % 10;
                }

                i /= 10;
            }

            return sum;
        }

        private static int SumOdd(int i)
        {
            int sum = 0;

            while (i > 0)
            {
                if (i % 10 % 2 != 0)
                {
                    sum += i % 10;
                }

                i /= 10;
            }

            return sum;
        }
    }
}
