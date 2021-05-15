using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.FirstAndReserveTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team("My Team");

            int playerCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < playerCount; i++)
            {
                string[] data = Console.ReadLine().Split();

                Person player = new Person(data[0], data[1], int.Parse(data[2]), double.Parse(data[3]));
                team.AddPlayer(player);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players");
        }
    }
}
