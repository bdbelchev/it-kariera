using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResellValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string carModel = Console.ReadLine();
            double carPrice = int.Parse(Console.ReadLine());
            double days = int.Parse(Console.ReadLine());

            double totalPrice = carPrice + carPrice * 0.2 + 275 + days * 20;
            double profit = 0.15 * totalPrice;

            Console.WriteLine($"The {carModel} with initial price of {carPrice:f2} BGN will sell for {totalPrice + profit:f2} BGN");
            Console.WriteLine($"Profit: {profit:f2} BGN");
        }
    }
}
