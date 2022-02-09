using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._FindOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int start = input[0];
            int end = input[1];

            List<int> ints = new List<int>();

            for (int i = start; i <= end; i++)
            {
                ints.Add(i);
            }

            Predicate<int> isEven = i => i % 2 == 0;

            switch (Console.ReadLine())
            {
                case "odd":
                    Console.WriteLine(String.Join(' ', ints.Where(i => !isEven(i))));
                    break;
                case "even":
                    Console.WriteLine(String.Join(' ', ints.Where(i => isEven(i))));
                    break;
            }
        }
    }
}
