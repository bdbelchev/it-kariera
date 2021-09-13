using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SelectionSort
{
    public class SelectionSort
    {
        public static void Sort<T>(T[] a) where T : IComparable<T>
        {
            for (int i = 0; i < a.Length; i++)
            {
                int min = i;

                for (int j = i; j < a.Length; j++)
                {
                    if (Less(a[j], a[min]))
                    {
                        min = j;
                    }
                }

                Swap(a, i, min);
            }
        }

        private static bool Less<T>(T first, T second) where T : IComparable<T>
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
