using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.UpdatedWarehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productNames = Console.ReadLine().Split(' ').ToArray();

            long[] productAmounts = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            double[] productPrices = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            bool isRunning = true;
            while (isRunning)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                if (command[0] == "done")
                {
                    isRunning = false;
                }
                else
                {
                    int index = Array.IndexOf(productNames, command[0]);
                    if (index >= productAmounts.Length || int.Parse(command[1]) > productAmounts[index])
                    {
                        Console.WriteLine($"We do not have enough {productNames[index]}");
                    }
                    else
                    {
                        Console.WriteLine($"{productNames[index]} x {command[1]} costs {int.Parse(command[1]) * productPrices[index]:f2}");
                        productAmounts[index] -= int.Parse(command[1]);
                    }
                }
            }
        }
    }
}
