using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int axeWidth = 5 * n;
            int leftDashes = 3 * n;
            int middleDashes = 0;
            int rightDashes = axeWidth - leftDashes - middleDashes - 2;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDashes),
                    new string('-', middleDashes),
                    new string('-', rightDashes));
                middleDashes++;
                rightDashes--;
            }

            middleDashes--;
            rightDashes++;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('*', leftDashes),
                    new string('-', middleDashes),
                    new string('-', rightDashes));

            }

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDashes),
                    new string('-', middleDashes),
                    new string('-', rightDashes));
                rightDashes--;
                leftDashes--;
                middleDashes += 2;
            }

            Console.WriteLine("{0}*{1}*{2}",
                new string('-', leftDashes),
                new string('*', middleDashes),
                new string('-', rightDashes));
        }
    }
}
