using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FootballMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string sector = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());

            int totalSeats = rows * seats;

            double ticketPrice = 0;
            switch (sector)
            {
                case "Sector A":
                    ticketPrice = 11.60;
                    break;
                case "Sector B":
                    ticketPrice = 14.50;
                    break;
                case "Sector C":
                    ticketPrice = 16.10;
                    break;
                case "Sector D":
                    ticketPrice = 8.40;
                    break;
            }

            double profit = totalSeats * ticketPrice;
            Console.WriteLine($"{sector} profit is {profit:f2} lv.");
        }
    }
}
