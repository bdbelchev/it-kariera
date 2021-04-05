using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, KeyValuePair<double, int>> database = new Dictionary<string, KeyValuePair<double, int>>();

            while (command[0] != "stocked")
            {
                string product = command[0];
                double price = double.Parse(command[1]);
                int amount = int.Parse(command[2]);

                if (!database.ContainsKey(product))
                {
                    database.Add(product, new KeyValuePair<double, int>(price, amount));
                }
                else
                {
                    database[product] = new KeyValuePair<double, int>(price, database[product].Value + amount);
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }

            double total = 0;

            foreach (var pair in database)
            {
                Console.WriteLine($"{pair.Key}: ${pair.Value.Key:f2} * {pair.Value.Value} = ${pair.Value.Key * pair.Value.Value:f2}");
                total += pair.Value.Key * pair.Value.Value;
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${total:f2}");
        }
    }
}
