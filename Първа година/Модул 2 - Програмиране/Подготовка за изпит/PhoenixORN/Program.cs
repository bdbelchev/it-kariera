using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixORN
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> squads = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "Blaze it!")
            {
                string creature = input[0];
                string squadMate = input[1];

                if (creature != squadMate)
                {
                    if (!squads.ContainsKey(creature))
                    {
                        squads.Add(creature, new List<string>());
                    }

                    if (!squads[creature].Contains(squadMate))
                    {
                        squads[creature].Add(squadMate);
                    }
                }

                input = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var squad in squads)
            {
                for (int i = 0; i < squad.Value.Count; i++)
                {
                    if (squads.ContainsKey(squad.Value[i]) && squads[squad.Value[i]].Contains(squad.Key))
                    {
                        squads[squad.Value[i]].Remove(squad.Key);
                        squad.Value.RemoveAt(i);
                    }
                }
            }

            squads = squads.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

            foreach (var squad in squads)
            {
                Console.WriteLine($"{squad.Key} : {squad.Value.Count}");
            }
        }
    }
}
