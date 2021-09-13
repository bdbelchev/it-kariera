using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Filtering
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] output = input.Where(i => i >= 0).ToArray();

            Console.WriteLine($"{{{string.Join(", ", input)}}}");
            Console.WriteLine($"{{{string.Join(", ", output)}}}");
        }
    }
}
