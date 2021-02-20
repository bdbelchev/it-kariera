using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayStats
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine($"Min = {ints.Min()}");
            Console.WriteLine($"Max = {ints.Max()}");
            Console.WriteLine($"Sum = {ints.Sum()}");
            Console.WriteLine($"Average = {ints.Average()}");
        }
    }
}
