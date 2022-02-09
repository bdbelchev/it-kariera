using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MinFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<List<int>, int> getMinFunc = l => l.Min();

            Action<int> printer = i => Console.WriteLine(i);

            printer(getMinFunc(ints));
        }
    }
}
