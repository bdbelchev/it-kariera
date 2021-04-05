using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.LogManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, KeyValuePair<int, List<string>>> logs =
                new SortedDictionary<string, KeyValuePair<int, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string ip = input[0];
                string username = input[1];
                int duration = int.Parse(input[2]);

                if (!logs.ContainsKey(username))
                {
                    logs.Add(username, new KeyValuePair<int, List<string>>(0, new List<string>()));
                }

                if (!logs[username].Value.Contains(ip))
                {
                    logs[username].Value.Add(ip);
                }

                logs[username] = new KeyValuePair<int, List<string>>(logs[username].Key + duration, logs[username].Value);
            }

            foreach (var user in logs)
            {
                Console.WriteLine($"{user.Key}: {user.Value.Key} [{string.Join(", ", user.Value.Value)}]");

            }
        }
    }
}
