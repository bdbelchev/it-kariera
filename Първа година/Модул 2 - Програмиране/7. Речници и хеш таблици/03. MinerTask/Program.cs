using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int i = 1;
            string current = "";
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (input != "stop")
            {
                if (i % 2 != 0)
                {
                    current = input;

                    if (!resources.ContainsKey(current))
                    {
                        resources.Add(current, 0);
                    }
                }
                else
                {
                    int amount = int.Parse(input);
                    resources[current] += amount;
                }

                input = Console.ReadLine();
                i++;
            }

            foreach (var pair in resources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
