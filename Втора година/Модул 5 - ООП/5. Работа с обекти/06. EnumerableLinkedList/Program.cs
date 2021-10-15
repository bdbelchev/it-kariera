using System;
using System.Linq;

namespace _06._EnumerableLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "Add":
                        list.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        list.Remove(int.Parse(command[1]));
                        break;
                }
            }

            Console.WriteLine(list.Count);
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
