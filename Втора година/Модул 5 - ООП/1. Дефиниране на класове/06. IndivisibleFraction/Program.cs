using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._IndivisibleFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RationalNumber> numbers = new List<RationalNumber>();

            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length - 1; i++)
            {
                int n = input[i++];
                int d = input[i];

                RationalNumber number = new RationalNumber(n, d);

                numbers.Add(number);
            }

            List<RationalNumber> newNumbers = numbers.Select(RationalNumber.Convert).ToList();

            Console.WriteLine(string.Join("; ", newNumbers));
        }
    }
}
