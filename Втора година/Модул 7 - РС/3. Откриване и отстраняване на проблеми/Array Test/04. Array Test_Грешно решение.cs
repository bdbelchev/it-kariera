namespace Arrays
{
    using System;
    using System.Linq;

    public class ArraysMain
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop")) //was "over"
            {
                string line = command.Split(ArgumentsDelimiter).First();
                int[] args = new int[2];

                if (line.Equals("add") ||
                    line.Equals("subtract") || //had typo
                    line.Equals("multiply"))
                {
                    string[] stringParams = command.Split(ArgumentsDelimiter);
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);

                    array = PerformAction(array, line, args);
                    //command handling was a bit wrong
                }
                else
                {
                    array = PerformAction(array, command, args);
                }

                PrintArray(array);
                Console.WriteLine('\n');

                command = Console.ReadLine();
            }
        }

        static long[] PerformAction(long[] arr, string action, int[] args)
        {
            //method didn't return anything
            long[] array = arr.Clone() as long[];
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }

            return array;
        }

        private static void ArrayShiftRight(long[] array)
        {
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
        }

        private static void ArrayShiftLeft(long[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}
