using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string place = "";
            double price = 0;

            if (budget > 1000)
            {
                destination = "Europe";
                place = "Hotel";
            }
            else if (budget > 100)
            {
                destination = "Balkans";
            }
            else
            {
                destination = "Bulgaria";
            }

            if (season == "summer" && destination != "Europe")
            {
                place = "Camp";
                if (destination == "Bulgaria")
                {
                    price = 0.3 * budget;
                }
                else if (destination == "Balkans")
                {
                    price = 0.4 * budget;
                }
            }
            else
            {
                place = "Hotel";
                if (destination == "Bulgaria")
                {
                    price = 0.7 * budget;
                }
                else if (destination == "Balkans")
                {
                    price = 0.8 * budget;
                }
                else if (destination == "Europe")
                {
                    price = 0.9 * budget;
                }
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {price:f2}");
        }
    }
}
