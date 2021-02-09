using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeNumberSign
{
    class Program
    {
        static void PrintSign(int n)
        {
            string sign = "";

            if (n > 0)
            {
                sign = "positive";
            }
            else if (n == 0)
            {
                sign = "zero";
            }
            else
            {
                sign = "negative";
            }

            Console.WriteLine($"The number {n} is {sign}.");
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
    }
}
