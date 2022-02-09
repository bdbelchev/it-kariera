using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Action
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            Action<List<string>> printer = l => l.ForEach(s => Console.WriteLine(s));

            printer(input);
        }
    }
}
