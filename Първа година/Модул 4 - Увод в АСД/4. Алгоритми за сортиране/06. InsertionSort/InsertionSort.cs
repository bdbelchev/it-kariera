using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.InsertionSort
{
    class InsertionSort
    {
        public static void Sort<T>(T[] a) where T : IComparable<T>
        {
            for (int i = 1; i < a.Length; i++)
            {
                while (i > 0 && Less(a[i], a[i - 1]))
                {
                    Swap(a, i, i - 1);
                    i--;
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
