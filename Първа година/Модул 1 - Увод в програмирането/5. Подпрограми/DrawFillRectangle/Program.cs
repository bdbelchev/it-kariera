using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFillRectangle
{
    class Program
    {
        static void PrintTopBottom(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void PrintMiddle(int n)
        {
            Console.Write('-');

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine('-');
        }

        static void PrintRect(int n)
        {
            PrintTopBottom(n);

            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddle(n);
            }

            PrintTopBottom(n);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintRect(n);
        }
    }
}
