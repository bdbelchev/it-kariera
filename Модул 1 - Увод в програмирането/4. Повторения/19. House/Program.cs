using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _19.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int starCount = n % 2 == 0 ? 2 : 1;
            int dashCount = (n - starCount) / 2;

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', dashCount), new string('*', starCount));
                dashCount--;
                starCount += 2;
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine($"|{new string('*', n - 2)}|");
            }
        }
    }
}
