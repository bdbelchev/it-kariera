﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.PrintASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startRange = int.Parse(Console.ReadLine());
            int endRange = int.Parse(Console.ReadLine());

            for (int i = startRange; i <= endRange; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
