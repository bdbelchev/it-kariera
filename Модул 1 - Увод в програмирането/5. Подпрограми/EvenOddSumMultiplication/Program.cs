using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddSumMultiplication
{
    class Program
    {
        static double Multiply(double even, double odd)
        {
            return even * odd;
        }

        static double GetEvenSum(int n)
        {
            double sum = 0;
            while (n > 0)
            {
                int last = n % 10;
                n /= 10;
                if (last % 2 == 0)
                {
                    sum += last;
                }
            }

            return sum;
        }

        static double GetOddSum(int n)
        {
            double sum = 0;
            while (n > 0)
            {
                int last = n % 10;
                n /= 10;
                if (last % 2 != 0)
                {
                    sum += last;
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            double result = Multiply(GetEvenSum(n), GetOddSum(n));
            Console.WriteLine(result);
        }
    }
}
