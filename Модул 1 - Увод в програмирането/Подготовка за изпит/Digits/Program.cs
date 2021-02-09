using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int first = int.Parse(num.ToString().Substring(0, 1));
            int second = int.Parse(num.ToString().Substring(1, 1));
            int third = int.Parse(num.ToString().Substring(2, 1));

            int n = first + second;
            int m = first + third;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (num % 5 == 0)
                    {
                        num -= first;
                    }
                    else if (num % 3 == 0)
                    {
                        num -= second;
                    }
                    else
                    {
                        num += third;
                    }

                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
