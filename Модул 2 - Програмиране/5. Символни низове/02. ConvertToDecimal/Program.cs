using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DecimalConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int fromBase = input[0];
            int number = input[1];

            int result = ConvertToDecimal(number, fromBase);
            Console.WriteLine(result);
        }

        private static int ConvertToDecimal(int n, int fromBase)
        {
            int converted = 0;

            int power = 0;

            while (n > 0)
            {
                int remainder = n % 10;
                n /= 10;
                converted += remainder * (int)Math.Pow(fromBase, power);
                power += 1;
            }

            return converted;
        }
    }
}