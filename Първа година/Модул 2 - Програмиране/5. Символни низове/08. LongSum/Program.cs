using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LongSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            List<int> num1Digits = new List<int>();
            List<int> num2Digits = new List<int>();

            foreach (char c in num1)
            {
                num1Digits.Add(int.Parse(c.ToString()));
            }

            foreach (char c in num2)
            {
                num2Digits.Add(int.Parse(c.ToString()));
            }

            while (num1Digits.Count != num2Digits.Count)
            {
                if (num1Digits.Count > num2Digits.Count)
                {
                    num2Digits.Insert(0, 0);
                }
                else if (num2Digits.Count > num1Digits.Count)
                {
                    num1Digits.Insert(0, 0);
                }
            }

            List<int> resultNumber = new List<int>();

            for (int i = 0; i < num1Digits.Count; i++)
            {
                resultNumber.Insert(i, 0);
            }

            for (int i = num1Digits.Count - 1; i >= 0; i--)
            {
                int sum = num1Digits[i] + num2Digits[i];

                if (sum >= 10 && i != 0)
                {
                    resultNumber[i] = sum % 10;
                    num1Digits[i - 1] += sum / 10;
                }
                else
                {
                    resultNumber[i] = sum;
                }
            }

            Console.WriteLine(string.Join("", resultNumber));
        }
    }
}
