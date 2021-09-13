using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.GetMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = ints.Length;

            if (n == 1)
            {
                Console.WriteLine($"{{ {ints[0]} }}");
            }
            else if (n % 2 == 0)
            {
                int[] values = new[] { ints[n / 2 - 1], ints[n / 2] };
                Console.WriteLine($"{{ {string.Join(", ", values)} }}");
            }
            else if (n % 2 != 0)
            {
                int[] values = new[] { ints[n / 2 - 1], ints[n / 2], ints[n / 2 + 1] };
                Console.WriteLine($"{{ {string.Join(", ", values)} }}");
            }
        }
    }
}
