using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _15._Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> creatures = new List<IBirthable>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] data = input.Split().ToArray();

                switch (data[0])
                {
                    case "Robot":
                        Robot robot = new Robot(data[2], data[1]);
                        break;
                    case "Citizen":
                        Citizen citizen = new Citizen(data[3], data[1], int.Parse(data[2]), Convert.ToDateTime(data[4]));
                        creatures.Add(citizen);
                        break;
                    case "Pet":
                        Pet pet = new Pet(data[1], Convert.ToDateTime(data[2]));
                        creatures.Add(pet);
                        break;
                }

                input = Console.ReadLine();
            }

            int year = int.Parse(Console.ReadLine());

            foreach (IBirthable creature in creatures.Where(c => c.Birthdate.Year == year))
            {
                Console.WriteLine(creature.Birthdate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
            }
        }
    }
}
