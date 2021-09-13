using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.MaxRepeatingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int mostCommon = 0;
            int largestOccurence = 0;

            foreach (int i in ints)
            {
                int counter = 0;

                foreach (int j in ints)
                {
                    if (i == j)
                    {
                        counter++;
                    }

                }

                if (counter > largestOccurence)
                {
                    mostCommon = i;
                    largestOccurence = counter;
                }
            }

            for (int i = 0; i < largestOccurence; i++)
            {
                Console.Write($"{mostCommon} ");
            }
        }
    }
}
