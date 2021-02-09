using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonSale
{
    class Program
    {
        static void Main(string[] args)
        {
            string carModel = Console.ReadLine();
            string carType = Console.ReadLine().ToLower();
            string season = Console.ReadLine().ToLower();
            string carState = Console.ReadLine().ToLower();
            double initialPrice = double.Parse(Console.ReadLine());
            double neededProfit = double.Parse(Console.ReadLine());

            double profit = 0;

            switch (carState)
            {
                case "perfect":
                    profit = carType == "suv" ? 0.3 * initialPrice : 0.25 * initialPrice;
                    break;
                case "good":
                    profit = carType == "suv" ? 0.2 * initialPrice : 0.15 * initialPrice;
                    break;
                case "bad":
                    profit = 0.1 * initialPrice;
                    break;
            }

            if (season == "winter")
            {
                profit -= 200;
            }

            if (profit >= neededProfit)
            {
                Console.WriteLine($"The profit on {carModel} will be good - {profit:f2} BGN");
            }
            else
            {
                Console.WriteLine("The car is not worth selling now");
                Console.WriteLine($"Need {neededProfit - profit:f2} more profit");
            }
        }
    }
}
