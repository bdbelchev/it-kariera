using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.PyramidOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int row = 1; row <= n; row++)
            {
                if (num > n)
                {
                    break;
                }
                for (int col = 1; col <= row; col++)
                {
                    if (num > n)
                    {
                        break;
                    }
                    Console.Write($"{num} ");
                    num++;
                }

                Console.WriteLine();
            }
        }
    }
}
