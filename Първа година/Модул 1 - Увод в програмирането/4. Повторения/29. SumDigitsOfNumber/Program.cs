using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.SumDigitsOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int digitSum = 0;

            while (num != 0)
            {
                digitSum += num % 10;
                num /= 10;
            }

            Console.WriteLine(digitSum);
        }
    }
}
