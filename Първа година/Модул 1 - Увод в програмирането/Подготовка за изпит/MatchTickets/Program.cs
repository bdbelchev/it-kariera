using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleInGroup = int.Parse(Console.ReadLine());

            double transportBudget = 0;
            if (peopleInGroup >= 50)
            {
                transportBudget = 0.25 * budget;
            }
            else if (peopleInGroup >= 25)
            {
                transportBudget = 0.4 * budget;
            }
            else if (peopleInGroup >= 10)
            {
                transportBudget = 0.5 * budget;
            }
            else if (peopleInGroup >= 5)
            {
                transportBudget = 0.6 * budget;
            }
            else if (peopleInGroup >= 1)
            {
                transportBudget = 0.75 * budget;
            }

            double ticketPrice = 0;
            switch (category)
            {
                case "VIP":
                    ticketPrice = peopleInGroup * 499.99;
                    break;
                case "Normal":
                    ticketPrice = peopleInGroup * 249.99;
                    break;
            }

            Console.WriteLine(transportBudget + ticketPrice > budget
                ? $"Not enough money! You need {Math.Abs((transportBudget + ticketPrice) - budget):f2} leva."
                : $"Yes! You have {Math.Abs((transportBudget + ticketPrice) - budget):f2} leva left.");
        }
    }
}
