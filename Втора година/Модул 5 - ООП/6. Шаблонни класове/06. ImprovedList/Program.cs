using System;
using System.Linq;

namespace _06._ImprovedList
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversalList<string> list = new UniversalList<string>();

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Add":
                        list.Add(command[1]);
                        break;
                    case "Remove":
                        list.Remove(int.Parse(command[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(list.Contains(command[1]));
                        break;
                    case "Swap":
                        list.Swap(int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(list.CountGreaterThan(command[1]));
                        break;
                    case "Max":
                        Console.WriteLine(list.Max());
                        break;
                    case "Min":
                        Console.WriteLine(list.Min());
                        break;
                    case "Print":
                        foreach (string s in list)
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    case "Sort":
                        list = Sorter<string>.Sort(list);
                        break;
                }

                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
