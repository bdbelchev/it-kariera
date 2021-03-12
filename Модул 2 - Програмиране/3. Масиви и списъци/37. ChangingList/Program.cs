using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _37.ChangingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "Odd" && command != "Even")
            {
                List<string> commandArgs = command.Split(' ').ToList();

                switch (commandArgs[0])
                {
                    case "Delete":
                        int removeValue = int.Parse(commandArgs[1]);
                        numbers.RemoveAll(e => e == removeValue);
                        break;

                    case "Insert":
                        int insertValue = int.Parse(commandArgs[1]);
                        int pos = int.Parse(commandArgs[2]);
                        numbers.Insert(pos, insertValue);
                        break;
                }

                command = Console.ReadLine();
            }

            if (command == "Odd")
            {
                foreach (int i in numbers)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }

            else if (command == "Even")
            {
                foreach (int i in numbers)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }

        }
    }
}
