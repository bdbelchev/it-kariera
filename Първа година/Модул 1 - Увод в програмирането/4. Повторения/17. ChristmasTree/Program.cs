using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int spacesCount = n;
            int starsCount = 0;

            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine("{0}{1} | {1}", new string(' ', spacesCount), new string('*', starsCount));
                spacesCount--;
                starsCount++;
            }
        }
    }
}
