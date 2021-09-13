using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _2.FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double shirtPrice = double.Parse(Console.ReadLine());
            double sumNeeded = double.Parse(Console.ReadLine());

            double shortPrice = 0.75 * shirtPrice;
            double sockPrice = 0.2 * shortPrice;
            double shoePrice = (shirtPrice + shortPrice) * 2;

            double totalSum = shirtPrice + shortPrice + sockPrice + shoePrice;
            totalSum -= 0.15 * totalSum;

            if (totalSum >= sumNeeded)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalSum:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {sumNeeded - totalSum:f2} lv. more.");
            }
        }
    }
}
