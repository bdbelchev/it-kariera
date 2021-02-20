using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LetterIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[26];

            for (int i = 0; i < 26; i++)
            {
                letters[i] = (char)(i + 97);
            }

            string input = Console.ReadLine();

            foreach (char c in input)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (c == letters[i])
                    {
                        Console.WriteLine($"{c} -> {i}");
                    }
                }
            }
        }
    }
}
