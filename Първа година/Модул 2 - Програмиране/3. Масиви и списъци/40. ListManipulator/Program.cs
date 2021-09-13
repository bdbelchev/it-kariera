using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.ListManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                List<string> commandArgs = command.Split(' ').ToList();

                switch (commandArgs[0])
                {
                    case "add":
                        AddCommand(numbers, commandArgs);
                        break;
                    case "addMany":
                        AddManyCommand(numbers, commandArgs);
                        break;
                    case "remove":
                        RemoveCommand(numbers, commandArgs);
                        break;
                    case "contains":
                        ContainsCommand(numbers, commandArgs);
                        break;
                    case "shift":
                        ShiftCommand(numbers, commandArgs);
                        break;
                    case "sumPairs":
                        SumPairsCommand(numbers);
                        break;

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[ {string.Join(", ", numbers)} ]");
        }

        private static void SumPairsCommand(List<int> numbers)
        {
            List<int> pairList = new List<int>();

            for (int i = 0; i < numbers.Count - 1; i += 2)
            {
                pairList.Add(numbers[i] + numbers[i + 1]);
            }

            if (numbers.Count % 2 != 0)
            {
                pairList.Add(numbers[numbers.Count - 1]);
            }

            numbers.Clear();
            numbers.AddRange(pairList);
        }

        private static void ShiftCommand(List<int> numbers, List<string> commandArgs)
        {
            int shiftCount = int.Parse(commandArgs[1]);

            if (numbers.Count <= shiftCount)
            {
                return;
            }

            List<int> result = numbers.GetRange(shiftCount, numbers.Count - shiftCount);
            result.AddRange(numbers.GetRange(0, shiftCount));

            numbers.Clear();
            numbers.AddRange(result);
        }

        private static void ContainsCommand(List<int> numbers, List<string> commandArgs)
        {
            int containsValue = int.Parse(commandArgs[1]);
            Console.WriteLine(numbers.IndexOf(containsValue));
        }

        private static void RemoveCommand(List<int> numbers, List<string> commandArgs)
        {
            int removeAt = int.Parse(commandArgs[1]);

            numbers.RemoveAt(removeAt);
        }

        private static void AddCommand(List<int> numbers, List<string> commandArgs)
        {
            int insertValue = int.Parse(commandArgs[2]);
            int pos = int.Parse(commandArgs[1]);

            numbers.Insert(pos, insertValue);
        }

        private static void AddManyCommand(List<int> numbers, List<string> commandArgs)
        {
            int addAt = int.Parse(commandArgs[1]);

            List<int> addRange = new List<int>();

            for (int i = 2; i < commandArgs.Count; i++)
            {
                addRange.Add(int.Parse(commandArgs[i]));
            }

            numbers.InsertRange(addAt, addRange);
        }
    }
}
