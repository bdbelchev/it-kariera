using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string topBottom = "+ " + new string('-', n - 2) + " +";
            string body = "| " + new string('-', n - 2) + " |";

            Console.WriteLine(topBottom);
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(body);
            }

            Console.WriteLine(topBottom);
        }
    }
}
