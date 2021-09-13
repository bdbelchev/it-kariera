using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            PopulateTrainers(trainers);
            Tournament(trainers);
            PrintResults(trainers);
        }

        private static void PrintResults(Dictionary<string, Trainer> trainers)
        {
            foreach (var trainer in trainers.OrderByDescending(t => t.Value.BadgeCount).ToDictionary(e => e.Key, e => e.Value).Values)
            {
                Console.WriteLine($"{trainer.Name} {trainer.BadgeCount} {trainer.Collection.Count}");
            }
        }

        private static void Tournament(Dictionary<string, Trainer> trainers)
        {
            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                foreach (var trainer in trainers.Values)
                {
                    bool hasElement = trainer.Collection.Any(p => p.Element == input[0]);

                    if (hasElement)
                    {
                        trainer.BadgeCount++;
                    }
                    else
                    {
                        foreach (Pokemon pokemon in trainer.Collection)
                        {
                            pokemon.Health -= 10;
                        }
                    }

                    trainer.CheckHealth();
                }

                input = Console.ReadLine().Split();
            }
        }

        private static void PopulateTrainers(Dictionary<string, Trainer> trainers)
        {
            string[] input = Console.ReadLine().Split();

            while (input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string element = input[2];
                int health = int.Parse(input[3]);

                Pokemon pokemon = new Pokemon(pokemonName, element, health);

                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainers.Add(trainerName, trainer);
                }

                trainers[trainerName].Collection.Add(pokemon);

                input = Console.ReadLine().Split();
            }
        }
    }
}
