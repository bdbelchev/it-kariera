using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DiamondOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int spacesCount = n - 1;
            int starsCount = 1;

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', spacesCount));
                for (int col = 1; col <= starsCount; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                starsCount++;
                spacesCount--;
            }

            starsCount -= 2;
            spacesCount += 2;

            for (int row = 1; row <= n - 1; row++)
            {
                Console.Write(new string(' ', spacesCount));
                for (int col = 1; col <= starsCount; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                starsCount--;
                spacesCount++;
            }
        }
    }
}
