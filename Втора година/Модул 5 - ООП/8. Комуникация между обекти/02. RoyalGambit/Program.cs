using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _02._RoyalGambit
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IKillable> alive = new Dictionary<string, IKillable>();

            string kingName = Console.ReadLine();

            string[] guardNames = Console.ReadLine().Split();

            string[] footNames = Console.ReadLine().Split();

            King king = new King(kingName);

            foreach (string guardName in guardNames)
            {
                if (!alive.ContainsKey(guardName))
                {
                    alive.Add(guardName, new RoyalGuard(guardName));
                }
            }

            foreach (string footName in footNames)
            {
                if (!alive.ContainsKey(footName))
                {
                    alive.Add(footName, new Footman(footName));
                }
            }

            foreach (IKillable person in alive.Values)
            {
                king.KingAttack += person.OnKingAttack;
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command.StartsWith("Kill"))
                {
                    string killedName = command.Split().Last();
                    king.KingAttack -= alive[killedName].OnKingAttack;
                    alive.Remove(killedName);
                }
                else if (command == "Attack King")
                {
                    king.Attack();
                }

                command = Console.ReadLine();
            }
        }
    }
}
