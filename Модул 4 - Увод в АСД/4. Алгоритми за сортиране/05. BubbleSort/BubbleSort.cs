using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BubbleSort
{
    class BubbleSort
    {
        public static void Sort<T>(T[] a) where T : IComparable<T>
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (Less(a[j + 1], a[j]))
                    {
                        Swap(a, j, j + 1);
                    }
                }
            }
        }

        static bool Less<T>(T first, T second) where T : IComparable<T>
        {
            return first.CompareTo(second) < 0;
        }

        static void Swap<T>(T[] collection, int from, int to)
        {
            Console.WriteLine(string.Join(", ", collection));

            T first = collection[from];
            T second = collection[to];

            collection[from] = second;
            collection[to] = first;

            Console.WriteLine($"Swapped {first} and {second} → {string.Join(", ", collection)}\n");
        }
    }
}
