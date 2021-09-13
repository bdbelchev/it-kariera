using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MostCommonNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int mostCommon = 0;
            int largestOccurrence = 0;

            foreach (int i in numbers)
            {
                int counter = 0;

                foreach (int j in numbers)
                {
                    if (i == j)
                    {
                        counter++;
                    }
                }

                if (counter > largestOccurrence)
                {
                    mostCommon = i;
                    largestOccurrence = counter;
                }
            }

            Console.WriteLine(mostCommon);
        }
    }
}
