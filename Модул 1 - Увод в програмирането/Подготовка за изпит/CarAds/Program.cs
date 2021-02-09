using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int gasCount = 0;
            int dieselCount = 0;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                string type = Console.ReadLine();
                string fuel = Console.ReadLine();
                string status = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                double km = double.Parse(Console.ReadLine());

                string category = "";

                switch (type)
                {
                    case "coupe" when fuel == "gasoline":
                        category = price > 100000 ? "supersport" : "sport";
                        break;
                    case "coupe" when fuel == "diesel":
                        category = "ecosport";
                        break;
                    case "sedan" when fuel == "gasoline":
                        category = "executive";
                        break;
                    case "sedan" when fuel == "diesel":
                        category = "economic";
                        break;
                }

                if (status == "vip")
                {
                    price += 200;
                }

                if (fuel == "gasoline")
                {
                    gasCount++;
                }
                else
                {
                    dieselCount++;
                }

                Console.WriteLine($"Car model - {model}");
                Console.WriteLine($"Category - {category}");
                Console.WriteLine($"Type - {type}");
                Console.WriteLine($"Fuel - {fuel}");
                Console.WriteLine($"Kilometers - {km}");
                Console.WriteLine($"Price - {price:f2}");
            }

            double gasPercentage = (gasCount / double.Parse(n.ToString())) * 100;
            double dieselPercentage = (dieselCount / double.Parse(n.ToString())) * 100;

            Console.WriteLine($"Gasoline cars: {gasPercentage:f2}%");
            Console.WriteLine($"Diesel cars: {dieselPercentage:f2}%");
        }
    }
}
