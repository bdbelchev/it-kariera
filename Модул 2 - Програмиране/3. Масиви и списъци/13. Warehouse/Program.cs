using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Warehouse
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
                string command = Console.ReadLine();

                if (command=="done")
                {
                    isRunning = false;
                }
                else
                {
                    int index = Array.IndexOf(productNames, command);
                    Console.WriteLine($"{productNames[index]} costs: {productPrices[index]}; Available quantity: {productAmounts[index]}");
                }
            }
        }
    }
}
