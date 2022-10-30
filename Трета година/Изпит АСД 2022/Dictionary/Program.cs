using System;

namespace Dictionary
{
    internal class Program
    {
        static int count;

        static void Main(string[] args)
        {
            string[] fufuWords = new string[650];

            GenerateFufu(fufuWords, 0, new char[2], new bool[26]);

            string word = Console.ReadLine();

            FufuLookup(word, fufuWords);
        }

        private static void FufuLookup(string word, string[] dictionary)
        {
            int index = Array.IndexOf(dictionary, word);
            Console.WriteLine(index == -1 ? "No FuFu" : $"{index + 1}");
        }

        static void GenerateFufu(string[] dictionary, int index, char[] current, bool[] used)
        {
            if (index >= current.Length)
            {
                dictionary[count] = string.Join("", current);
                count++;
                return;
            }

            for (int i = 0; i < 26; i++)
            {
                if (!used[i])
                {
                    current[index] = (char)(97 + i);
                    used[i] = true;
                    GenerateFufu(dictionary, index + 1, current, used);
                    used[i] = false;
                }
            }
        }
    }
}
