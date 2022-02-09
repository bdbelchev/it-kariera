using System;
using System.Linq;

namespace _06._Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Console.WriteLine(ints.Length);
            Console.WriteLine(ints.Sum());
        }
    }
}
