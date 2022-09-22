using System.Runtime.InteropServices;

namespace _04._Combinatorics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] set = { "A", "B", "C", "D" };
            //Permute(set, 0, new string[set.Length], new bool[set.Length]);
            SwapPermute(set, 0);
            Console.WriteLine();
            Variate(set, 0, new string[2], new bool[set.Length]);
            Console.WriteLine();
            Combine(set, 0, 0, new string[2]);
        }

        private static void SwapPermute(string[] set, int index)
        {
            if (index >= set.Length)
            {
                Console.WriteLine(string.Join(" ", set));
                return;
            }

            SwapPermute(set, index + 1);
            for (int i = index + 1; i < set.Length; i++)
            {
                Swap(set, index, i);
                SwapPermute(set, index + 1);
                Swap(set, index, i);
            }
        }

        private static void Swap(string[] set, int i1, int i2)
        {
            string prev = set[i1];
            set[i1] = set[i2];
            set[i2] = prev;
        }

        private static void Combine(string[] set, int index, int currentElement, string[] currentCombo)
        {
            if (index >= currentCombo.Length)
            {
                Console.WriteLine(string.Join(" ", currentCombo));
                return;
            }

            for (int i = currentElement; i < set.Length; i++)
            {
                currentCombo[index] = set[i];
                Combine(set, index + 1, i + 1, currentCombo);
            }
        }

        private static void Variate(string[] set, int index, string[] currentVariation, bool[] used)
        {
            if (index >= currentVariation.Length)
            {
                Console.WriteLine(string.Join(" ", currentVariation));
                return;
            }

            for (int i = 0; i < set.Length; i++)
            {
                if (!used[i])
                {
                    currentVariation[index] = set[i];
                    used[i] = true;
                    Variate(set, index + 1, currentVariation, used);
                    used[i] = false;
                }
            }
        }

        private static void Permute(string[] set, int index, string[] currentPermutation, bool[] used)
        {
            if (index >= currentPermutation.Length)
            {
                Console.WriteLine(string.Join(" ", currentPermutation));
                return;
            }

            for (int i = 0; i < set.Length; i++)
            {
                if (!used[i])
                {
                    currentPermutation[index] = set[i];
                    used[i] = true;
                    Permute(set, index + 1, currentPermutation, used);
                    used[i] = false;
                }
            }
        }
    }
}