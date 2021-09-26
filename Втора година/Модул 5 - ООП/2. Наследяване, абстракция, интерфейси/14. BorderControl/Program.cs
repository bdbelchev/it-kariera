using System;
using System.Collections.Generic;
using System.Linq;

namespace _14._BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> ids = new List<IIdentifiable>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] data = input.Split().ToArray();

                switch (data.Length)
                {
                    case 2:
                        Robot robot = new Robot(data[1], data[0]);
                        ids.Add(robot);
                        break;
                    case 3:
                        Citizen citizen = new Citizen(data[2], data[0], int.Parse(data[1]));
                        ids.Add(citizen);
                        break;
                }

                input = Console.ReadLine();
            }

            string fakeEnding = Console.ReadLine();

            foreach (IIdentifiable p in ids.Where(p => p.ID.EndsWith(fakeEnding)))
            {
                Console.WriteLine(p.ID);
            }
        }
    }
}
