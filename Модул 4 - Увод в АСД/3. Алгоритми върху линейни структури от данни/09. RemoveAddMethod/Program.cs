using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RemoveAddMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            ints.Sort();

            int number = int.Parse(Console.ReadLine());

            List<int> newInts = new List<int>();
            newInts.AddRange(ints);

            if (newInts.Contains(number))
            {
                newInts.Remove(number);
            }
            else
            {
                for (int i = 0; i < newInts.Count; i++)
                {
                    if (number < newInts[i])
                    {
                        newInts.Insert(i, number);
                        break;
                    }
                }
            }

            Console.WriteLine($"Before: {string.Join(", ", ints)}");
            Console.WriteLine($"After: {string.Join(", ", newInts)}");
        }
    }
}
