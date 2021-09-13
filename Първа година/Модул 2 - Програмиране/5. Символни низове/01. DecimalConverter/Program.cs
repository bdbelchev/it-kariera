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

            int toBase = input[0];
            int decimalNumber = input[1];

            int result = ConvertToBase(decimalNumber, toBase);
            Console.WriteLine(result);
        }

        private static int ConvertToBase(int n, int toBase)
        {
            List<int> converted = new List<int>();

            while (n > 0)
            {
                int remainder = n % toBase;
                converted.Add(remainder);
                n /= toBase;
            }

            converted.Reverse();

            return int.Parse(string.Join("", converted));
        }
    }
}
