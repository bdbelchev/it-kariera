using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitters = new[] { ' ', '-', '>', '|' };
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<KeyValuePair<string, long>, string> cache = new Dictionary<KeyValuePair<string, long>, string>();

            string input = Console.ReadLine();

            while (input != "thetinggoesskrra")
            {
                if (input.Contains("->"))
                {
                    string[] info = input.Split(splitters, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string dataKey = info[0];
                    long dataSize = long.Parse(info[1]);
                    string dataSet = info[2];

                    if (data.ContainsKey(dataSet))
                    {
                        data[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        cache.Add(new KeyValuePair<string, long>(dataKey, dataSize), dataSet);
                    }
                }
                else if (!data.ContainsKey(input))
                {
                    data.Add(input, new Dictionary<string, long>());

                    KeyValuePair<KeyValuePair<string, long>, string>[] matchingCache = cache.Where(pair => pair.Value == input).ToArray();

                    foreach (var pair in matchingCache)
                    {
                        data[input].Add(pair.Key.Key, pair.Key.Value);
                        cache.Remove(pair.Key);
                    }
                }

                input = Console.ReadLine();
            }

            data = data.OrderByDescending(x => x.Value.Sum(pair => pair.Value)).ToDictionary(x => x.Key, x => x.Value);
            long totalSize = data.First().Value.Sum(pair => pair.Value);

            Console.WriteLine($"Data Set: {data.First().Key}, Total Size: {totalSize}");

            foreach (string key in data.First().Value.Keys)
            {
                Console.WriteLine($"$.{key}");
            }
        }
    }
}
