using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IntegerSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintSign(n);
        }

        private static void PrintSign(int n)
        {
            Console.Write($"The number {n} is ");

            if (n > 0)
            {
                Console.WriteLine("positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine("negative.");
            }
            else
            {
                Console.WriteLine("zero.");
            }
        }
    }
}
