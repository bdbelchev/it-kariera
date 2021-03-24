using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _19.RobotRoute
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            string direction = "right";

            string input = Console.ReadLine();
            List<string> commands = new List<string>();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (int.TryParse(input[i].ToString(), out _) && int.TryParse(input[i + 1].ToString(), out _))
                {
                    commands.Add(string.Concat(input[i], input[i + 1]));
                    i++;
                }
                else
                {
                    commands.Add(input[i].ToString());
                }
            }

            foreach (string command in commands)
            {
                if (int.TryParse(command, out int distance))
                {
                    x = MoveX(direction, x, distance);
                    y = MoveY(direction, y, distance);
                }
                else if (command == "L" || command == "R")
                {
                    direction = Rotate(direction, command);
                }
            }

            Console.WriteLine($"Position: (x: {x}, y: {y}), Distance = {Math.Sqrt(x * x + y * y):f2} m");
        }

        private static string Rotate(string direction, string command)
        {
            switch (direction)
            {
                case "left":
                    return command == "L" ? "down" : "up";
                case "right":
                    return command == "L" ? "up" : "down";
                case "up":
                    return command == "L" ? "left" : "right";
                case "down":
                    return command == "L" ? "right" : "left";
                default:
                    return direction;
            }
        }

        private static int MoveY(string direction, int value, int distance)
        {
            if (direction == "up")
            {
                value += distance;
            }
            else if (direction == "down")
            {
                value -= distance;
            }

            return value;
        }

        private static int MoveX(string direction, int value, int distance)
        {
            if (direction == "right")
            {
                value += distance;
            }
            else if (direction == "left")
            {
                value -= distance;
            }

            return value;
        }
    }
}
