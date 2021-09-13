using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ShoppingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> total = new Dictionary<string, double>();

            string input = Console.ReadLine();

            while (input != "Stop shopping")
            {
                string[] product = input.Split('-').ToArray();
                string productName = product[0];
                double price = double.Parse(product[1]);

                if (!total.ContainsKey(productName))
                {
                    total.Add(productName, price);
                }
                else
                {
                    total[productName] += price;
                }

                input = Console.ReadLine();
            }

            var sortedDict = total.OrderBy(pair => pair.Value);

            foreach (var pair in sortedDict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
            }

            Console.WriteLine($"Total sum: {total.Values.Sum():F2}");
        }
    }
}
