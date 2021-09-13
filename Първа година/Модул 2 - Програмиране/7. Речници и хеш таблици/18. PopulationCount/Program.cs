using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _18.PopulationCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> report = new Dictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split('|').ToArray();

            while (input[0] != "report")
            {
                string city = input[0];
                string country = input[1];
                int population = int.Parse(input[2]);

                if (!report.ContainsKey(country))
                {
                    report.Add(country, new Dictionary<string, int>());
                }

                report[country].Add(city, population);

                input = Console.ReadLine().Split('|').ToArray();
            }

            report = report.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(e => e.Key, e => e.Value);

            foreach (var pair in report)
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");

                foreach (var city in pair.Value)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
