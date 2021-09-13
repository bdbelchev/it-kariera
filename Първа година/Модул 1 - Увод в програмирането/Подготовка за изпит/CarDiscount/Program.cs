using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            string carModel = Console.ReadLine();
            int vinNumber = int.Parse(Console.ReadLine());
            string carState = Console.ReadLine();
            double carPrice = double.Parse(Console.ReadLine());

            if (carState == "good" && (vinNumber % 2 == 0 && vinNumber < 90000) && 0.15 * carPrice > 400)
            {
                Console.WriteLine($"yes - {carModel}");
                Console.WriteLine($"profit - {0.15 * carPrice:f2}");
            }
            else
            {
                Console.WriteLine("no");
                if (carState != "good")
                {
                    Console.WriteLine("The car is in bad condition");
                }
                if (vinNumber % 2 != 0 || vinNumber >= 90000)
                {
                    Console.WriteLine($"VIN {vinNumber} is not valid");
                }
                if (0.15 * carPrice < 400)
                {
                    Console.WriteLine($"Cannot make discount, profit too low - {0.15 * carPrice:f2}");
                }
            }
        }
    }
}
