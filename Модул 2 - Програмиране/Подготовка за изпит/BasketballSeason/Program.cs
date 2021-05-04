using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitters = new[] { ' ', '-' };
            SortedDictionary<string, int> results = new SortedDictionary<string, int>();

            string[] input = Console.ReadLine().Split(splitters, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "END")
            {
                string player = input[0];
                int points = int.Parse(input[1]);

                if (results.ContainsKey(player))
                {
                    results[player] += points;
                }
                else
                {
                    results.Add(player, points);
                }

                input = Console.ReadLine().Split(splitters, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var pair in results)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}