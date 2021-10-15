﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Frog
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Lake lake = new Lake(stones);

            List<int> result = new List<int>();

            foreach (int stone in lake)
            {
                result.Add(stone);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
