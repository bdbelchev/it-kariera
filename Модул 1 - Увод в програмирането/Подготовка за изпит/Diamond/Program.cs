using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int innerDashes = 1;
            int outerDashes = (n - 1) / 2;
            int stars = n % 2 == 0 ? 2 : 1;

            Console.WriteLine("{0}{1}{0}",
                new string('-', outerDashes),
                new string('*', stars));

            outerDashes--;
            innerDashes = n % 2 == 0 ? 2 : 1;

            for (int i = 0; i < (n - 2) / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('-', outerDashes),
                    new string('-', innerDashes));
                innerDashes += 2;
                outerDashes--;
            }

            if (n % 2 != 0)
            {
                Console.WriteLine($"*{new string('-', n - 2)}*");
            }

            outerDashes = 1;
            innerDashes = n - 4;

            for (int i = 0; i < (n - 2) / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('-', outerDashes),
                    new string('-', innerDashes));
                innerDashes -= 2;
                outerDashes++;
            }

            if (n % 2 != 0)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('-', outerDashes),
                    new string('*', stars));
            }
        }
    }
}
