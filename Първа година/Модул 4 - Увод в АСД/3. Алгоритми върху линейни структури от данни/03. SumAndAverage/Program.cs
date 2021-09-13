using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;
            double average = 0;

            foreach (int i in input)
            {
                sum += i;
            }

            average = (double)sum / input.Count;

            Console.WriteLine($"Sum={sum}; Average={average:f2}");
        }
    }
}
