using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int divisibleBy2 = 0;
            int divisibleBy3 = 0;
            int divisibleBy5 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    divisibleBy2++;
                }
                if (number % 3 == 0)
                {
                    divisibleBy3++;
                }
                if (number % 5 == 0)
                {
                    divisibleBy5++;
                }
            }

            Console.WriteLine(divisibleBy2);
            Console.WriteLine(divisibleBy3);
            Console.WriteLine(divisibleBy5);
        }
    }
}
