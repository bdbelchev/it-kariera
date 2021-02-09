using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int bodyLines = 0;

            Console.WriteLine(new string('|', 2 * n + 2));
            Console.WriteLine(new string('+', 2 * n + 2));
            Console.Write(new string('|', (2 * n - 4) / 2));
            Console.Write("GARAGE");
            Console.WriteLine(new string('|', (2 * n - 4) / 2));

            for (int i = 0; i < n - 4; i++)
            {
                Console.WriteLine(new string('|', 2 * n + 2));
                bodyLines++;
            }

            int doorHeight = bodyLines >= 1 ? 2 : 1;
            for (int i = 0; i < doorHeight; i++)
            {
                Console.Write("|{0}|{1}|{2}|", new string('/', n - 3), new string(' ', 4), new string('\\', n - 3));
                Console.WriteLine();
            }

            Console.Write(new string(' ', (2 * n - 3) / 2));
            Console.Write("/////");
            Console.WriteLine(new string(' ', (2 * n - 3) / 2));
        }
    }
}
