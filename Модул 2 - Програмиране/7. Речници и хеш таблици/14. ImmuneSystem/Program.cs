using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = int.Parse(Console.ReadLine());
            int health = initialHealth;
            string virus = Console.ReadLine();
            Dictionary<string, int> knownViruses = new Dictionary<string, int>();
            bool defeated = false;

            while (virus != "end")
            {

                int secsToBeat = 0;

                if (knownViruses.ContainsKey(virus))
                {
                    secsToBeat = knownViruses[virus] * virus.Length / 3;
                }
                else
                {
                    int power = 0;

                    foreach (char c in virus)
                    {
                        power += c;
                    }

                    power /= 3;
                    secsToBeat = power * virus.Length;

                    knownViruses.Add(virus, power);
                }

                Console.WriteLine($"Virus {virus}: {knownViruses[virus]} => {secsToBeat} seconds");

                if (secsToBeat > health)
                {
                    defeated = true;
                    Console.WriteLine("Immune system defeated");
                    break;
                }

                int timeInMin = secsToBeat / 60;
                int timeInSec = secsToBeat % 60;
                health -= secsToBeat;

                Console.WriteLine($"{virus} defeated in {timeInMin}m {timeInSec}s.");
                Console.WriteLine($"Remaining health: {health}");

                health += (int)(0.2 * health);

                if (health > initialHealth)
                {
                    health = initialHealth;
                }

                virus = Console.ReadLine();
            }

            if (!defeated)
            {
                Console.WriteLine($"Final health: {health}");
            }
        }
    }
}
