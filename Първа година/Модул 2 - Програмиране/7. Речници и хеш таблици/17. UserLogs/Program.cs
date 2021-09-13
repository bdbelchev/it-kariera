using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitterChars = new[] { ' ', '=' };

            SortedDictionary<string, Dictionary<string, int>> logs =
                new SortedDictionary<string, Dictionary<string, int>>();

            string[] input = Console.ReadLine().Split(splitterChars, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "end")
            {
                string ipAddress = input[1];
                string username = input[5];

                if (!logs.ContainsKey(username))
                {
                    logs.Add(username, new Dictionary<string, int>());
                    logs[username].Add(ipAddress, 1);
                }
                else if (logs[username].ContainsKey(ipAddress))
                {
                    logs[username][ipAddress]++;
                }
                else
                {
                    logs[username].Add(ipAddress, 1);
                }

                input = Console.ReadLine().Split(splitterChars, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var user in logs)
            {
                Console.WriteLine($"{user.Key}:");

                foreach (var log in user.Value)
                {
                    Console.WriteLine($"{log.Key} => {log.Value}");
                }

                Console.WriteLine();
            }
        }
    }
}
