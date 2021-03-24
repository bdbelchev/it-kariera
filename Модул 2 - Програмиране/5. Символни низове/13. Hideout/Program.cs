using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hideoutFound = false;
            string map = Console.ReadLine();

            while (!hideoutFound)
            {
                string[] clue = Console.ReadLine().Split(' ').ToArray();
                char symbol = Convert.ToChar(clue[0]);
                int count = int.Parse(clue[1]);

                for (int i = 0; i < map.Length; i++)
                {
                    if (map[i] == symbol)
                    {
                        int counter = 1;

                        for (int c = i; c < map.Length; c++)
                        {
                            if (map[c + 1] == symbol)
                            {
                                counter++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (counter >= count)
                        {
                            hideoutFound = true;
                            Console.WriteLine($"Hideout found at index {i} and it is with size {counter}!");
                            break;
                        }
                    }
                }
            }
        }
    }
}
