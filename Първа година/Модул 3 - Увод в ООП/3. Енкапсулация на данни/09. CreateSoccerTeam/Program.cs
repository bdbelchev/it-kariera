using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _09.CreateSoccerTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            string[] input = Console.ReadLine().Split(';');

            while (input[0] != "END")
            {
                string teamName = input[1];

                switch (input[0])
                {
                    case "Team":
                        Team team = new Team(teamName);
                        teams.Add(teamName, team);
                        break;
                    case "Add":
                        string playerName = input[2];
                        int endurance = int.Parse(input[3]);
                        int sprint = int.Parse(input[4]);
                        int dribble = int.Parse(input[5]);
                        int passing = int.Parse(input[6]);
                        int shooting = int.Parse(input[7]);

                        try
                        {
                            Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                            teams[teamName].AddPlayer(player);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    case "Remove":
                        string playerToRemove = input[2];
                        try
                        {
                            teams[teamName].RemovePlayer(playerToRemove);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "Rating":
                        teams[teamName].CalculateRating();
                        Console.WriteLine($"{teams[teamName].Name} - {teams[teamName].Rating}");
                        break;
                }

                input = Console.ReadLine().Split(';');
            }
        }
    }
}
