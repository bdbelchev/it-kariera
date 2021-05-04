using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dataStrings = Console.ReadLine().Split(' ').ToList();

            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "3:1")
            {
                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);
                int partitions = int.Parse(command[2]);

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                if (endIndex < 0)
                {
                    endIndex = 0;
                }

                if (endIndex >= dataStrings.Count)
                {
                    endIndex = dataStrings.Count - 1;
                }

                if (startIndex >= dataStrings.Count)
                {
                    startIndex = dataStrings.Count - 1;
                }

                switch (command[0])
                {
                    case "merge":
                        string result = "";

                        for (int i = 0; i <= endIndex - startIndex; i++)
                        {
                            result += dataStrings[startIndex];
                            dataStrings.RemoveAt(startIndex);
                        }

                        dataStrings.Insert(startIndex, result);

                        break;
                    case "divide":
                        string[] divided = new string[partitions];
                        int length = dataStrings[startIndex].Length / partitions;
                        int lastLength = dataStrings[startIndex].Length % partitions;

                        for (int i = 0; i < partitions; i++)
                        {
                            if (i == partitions - 1)
                            {
                                length += lastLength;
                            }

                            divided[i] = dataStrings[startIndex].Substring(0, length);
                            dataStrings[startIndex] = dataStrings[startIndex].Remove(0, length);
                        }

                        dataStrings.RemoveAt(startIndex);

                        for (int i = divided.Length - 1; i >= 0; i--)
                        {
                            dataStrings.Insert(startIndex, divided[i]);
                        }
                        break;
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(" ", dataStrings));
        }
    }
}
