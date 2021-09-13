using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plane = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split(' ').ToArray();
            int damage = 1;

            while (command[0] != "Supernova")
            {
                string direction = command[0];
                int steps = int.Parse(command[1]);

                for (int i = 0; i < steps; i++)
                {
                    if (direction == "left")
                    {
                        index--;
                    }
                    else
                    {
                        index++;
                    }

                    if (index < 0)
                    {
                        index = plane.Length - 1;
                        damage++;
                    }
                    else if (index > plane.Length - 1)
                    {
                        index = 0;
                        damage++;
                    }

                    plane[index] -= damage;
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(" ", plane));
        }
    }
}
