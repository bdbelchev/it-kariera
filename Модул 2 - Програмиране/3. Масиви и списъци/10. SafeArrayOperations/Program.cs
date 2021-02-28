﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SafeArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split(' ').ToArray();
            bool isRunning = true;

            while (isRunning)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                switch (command[0])
                {
                    case "Distinct":
                        inputStrings = DistinctArray(inputStrings);
                        break;
                    case "Reverse":
                        inputStrings = ReverseArray(inputStrings);
                        break;
                    case "Replace":
                        if (int.Parse(command[1]) < inputStrings.Length)
                        {
                            inputStrings = ReplaceArray(inputStrings, int.Parse(command[1]), command[2]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    case "END":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }

            PrintArray(inputStrings);
        }

        private static string[] ReplaceArray(string[] arr, int index, string word)
        {
            arr[index] = word;
            return arr;
        }

        private static string[] ReverseArray(string[] arr)
        {
            return arr.Reverse().ToArray();
        }

        private static void PrintArray(string[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        private static string[] DistinctArray(string[] arr)
        {
            return arr.Distinct().ToArray();
        }
    }
}
