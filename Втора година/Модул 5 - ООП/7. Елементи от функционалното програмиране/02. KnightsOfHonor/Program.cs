using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            Action<List<string>> printWithSir = l => l.ForEach(s => Console.WriteLine(s.Insert(0, "Sir ")));

            printWithSir(input);
        }
    }
}
