using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._DefineOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).Where(i => i % 2 != 0).ToList();

            List<OddNumber> result = input.Select(i => new OddNumber(i)).ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
