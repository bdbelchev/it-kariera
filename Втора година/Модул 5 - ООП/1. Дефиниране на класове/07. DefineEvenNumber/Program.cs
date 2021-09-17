using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._DefineEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).Where(i => i % 2 == 0).ToList();

            List<EvenNumber> result = input.Select(i => new EvenNumber(i)).ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
