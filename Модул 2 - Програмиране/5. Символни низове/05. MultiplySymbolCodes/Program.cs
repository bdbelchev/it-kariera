using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MultiplySymbolCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split(' ').ToArray();

            string str1 = inputStrings[0];
            string str2 = inputStrings[1];

            int sum = CalculateSumOfCharCodes(str1, str2);

            Console.WriteLine(sum);
        }

        private static int CalculateSumOfCharCodes(string str1, string str2)
        {
            int sum = 0;

            for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
            {
                sum += str1[i] * str2[i];
            }

            if (str1.Length != str2.Length)
            {
                for (int i = Math.Min(str1.Length, str2.Length); i < Math.Max(str1.Length, str2.Length); i++)
                {
                    sum += str1.Length > str2.Length ? str1[i] : str2[i];
                }
            }

            return sum;
        }
    }
}
