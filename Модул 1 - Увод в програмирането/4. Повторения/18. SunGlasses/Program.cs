using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.SunGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n;

            Console.WriteLine(new string('*', width) + new string(' ', n) + new string('*', width));
            for (int i = 0; i < n - 2; i++)
            {
                if (i == (n - 1) / 2 - 1)
                {
                    Console.WriteLine('*'
                                      + new string('/', width - 2)
                                      + '*' + new string('|', n)
                                      + '*' + new string('/', width - 2) + '*');
                }
                else
                {
                    Console.WriteLine('*'
                                      + new string('/', width - 2)
                                      + '*' + new string(' ', n)
                                      + '*' + new string('/', width - 2) + '*');
                }
            }
            Console.WriteLine(new string('*', width) + new string(' ', n) + new string('*', width));
        }
    }
}
