using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._DivisibleByK
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int k = int.Parse(Console.ReadLine());

            numbers = numbers.Where(i => i % k == 0).ToList();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
