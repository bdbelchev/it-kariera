using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ThreeBiggestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            input = input.OrderByDescending(n => n).ToList();

            Console.WriteLine(string.Join(" ", input.Take(3)));
        }
    }
}
