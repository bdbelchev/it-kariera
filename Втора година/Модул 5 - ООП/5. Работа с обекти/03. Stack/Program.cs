using System;
using System.Linq;

namespace _03._Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Push":
                        int[] ints = command.Skip(1).Select(i => int.Parse(i[0].ToString())).ToArray();
                        stack.Push(ints);
                        break;
                    case "Pop":
                        stack.Pop();
                        break;
                }

                command = Console.ReadLine().Split().ToArray();
            }

            for (int j = 0; j < 2; j++)
            {
                foreach (int i in stack)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
