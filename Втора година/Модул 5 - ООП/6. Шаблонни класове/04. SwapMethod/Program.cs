using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SwapMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box<string>> boxes = new List<Box<string>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                boxes.Add(new Box<string>(Console.ReadLine()));
            }

            int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Swap(boxes, command[0], command[1]);

            foreach (Box<string> box in boxes)
            {
                Console.WriteLine(box);
            }
        }

        private static void Swap(List<Box<string>> boxList, int box1, int box2)
        {
            Box<string> temp = boxList[box1];

            boxList[box1] = boxList[box2];
            boxList[box2] = temp;
        }
    }
}
