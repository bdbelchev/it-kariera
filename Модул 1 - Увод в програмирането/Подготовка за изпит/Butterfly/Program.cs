using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string stars = new string('*', n - 2);
            string dashes = new string('-', n - 2);
            string upperBody = "\\ /";
            string lowerBody = "/ \\";

            Console.WriteLine(stars + upperBody + stars);
            for (int i = 0; i < (n - 2) / 2; i++)
            {
                Console.WriteLine(dashes + upperBody + dashes);
                Console.WriteLine(stars + upperBody + stars);
            }

            Console.WriteLine(new string(' ', n - 1) + "@" + new string(' ', n - 1));

            Console.WriteLine(stars + lowerBody + stars);
            for (int i = 0; i < (n - 2) / 2; i++)
            {
                Console.WriteLine(dashes + lowerBody + dashes);
                Console.WriteLine(stars + lowerBody + stars);
            }
        }
    }
}
