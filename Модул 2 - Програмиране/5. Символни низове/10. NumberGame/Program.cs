using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split(' ').ToArray();

            double sum = 0;

            foreach (string s in inputStrings)
            {
                char[] numberChars = new char[s.Length - 2];

                for (int i = 0; i < s.Length - 2; i++)
                {
                    numberChars[i] = s[i + 1];
                }

                double number = double.Parse(string.Join("", numberChars));

                char letter1 = s[0];
                char letter2 = s[s.Length - 1];

                if (letter1.ToString().ToUpper() == letter1.ToString())
                {
                    number /= letter1 - 64;
                }
                else
                {
                    number *= letter1 - 96;
                }

                if (letter2.ToString().ToUpper() == letter2.ToString())
                {
                    number -= letter2 - 64;
                }
                else
                {
                    number += letter2 - 96;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
