﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.WinnerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numCount = 0;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if (i + j == n && k % 2 == 0 && (l == 3 || l == 6))
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                                numCount++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Count of winner numbers: {numCount}");
        }
    }
}
