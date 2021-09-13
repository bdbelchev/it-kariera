using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dotsCount = n + 1;
            int underscoresCount = n * 2 + 1;

            string topRow = new string('.', dotsCount)
                            + new string('_', underscoresCount)
                            + new string('.', dotsCount);
            Console.WriteLine(topRow);

            underscoresCount -= 2;
            dotsCount--;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', dotsCount));
                Console.Write("//");
                Console.Write(new string('_', underscoresCount));
                Console.Write("\\\\");
                Console.Write(new string('.', dotsCount));
                Console.WriteLine();
                dotsCount--;
                underscoresCount += 2;
            }

            string center = "//" + new string('_', ((underscoresCount - 5) / 2))
                                 + "STOP!" + new string('_', ((underscoresCount - 5) / 2))
                                 + "\\\\";
            Console.WriteLine(center);

            dotsCount = 0;
            underscoresCount = center.Length - 4;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', dotsCount));
                Console.Write("\\\\");
                Console.Write(new string('_', underscoresCount));
                Console.Write("//");
                Console.Write(new string('.', dotsCount));
                Console.WriteLine();
                underscoresCount -= 2;
                dotsCount++;
            }

        }
    }
}
