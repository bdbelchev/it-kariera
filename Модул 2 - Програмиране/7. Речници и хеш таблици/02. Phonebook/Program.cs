using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "A":
                        if (phonebook.ContainsKey(command[1]))
                        {
                            phonebook[command[1]] = command[2];
                        }
                        else
                        {
                            phonebook.Add(command[1], command[2]);
                        }
                        break;

                    case "S":
                        Console.WriteLine(phonebook.ContainsKey(command[1])
                            ? $"{command[1]} -> {phonebook[command[1]]}"
                            : $"Contact {command[1]} does not exist.");
                        break;
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
