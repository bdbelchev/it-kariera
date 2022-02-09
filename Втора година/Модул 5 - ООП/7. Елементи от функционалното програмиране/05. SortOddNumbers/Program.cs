using System;
using System.Linq;

namespace _05._SortOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            ints = ints.Where(i => i % 2 == 0).OrderBy(i => i).ToArray();

            Console.WriteLine(String.Join(", ", ints));
        }
    }
}
