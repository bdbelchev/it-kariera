using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongMultiplication
{
    class Program
    {
        static string Multiply(string num1, int num2)
        {
            string result = "";
            int j = 0;
            int rem = 0;

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int current = num2 * ((int)num1[i] - 48);

                if (rem > 0)
                {
                    current += rem;
                    rem = 0;
                }

                if (current >= 10)
                {
                    rem = current / 10;
                    current = current % 10;
                }

                result += current.ToString();
                j++;
            }

            if (rem > 0)
            {
                result += string.Join("", rem.ToString().Reverse());
            }

            return string.Join("", result.Reverse());
        }

        public static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Multiply(num1, num2));
        }
    }
}