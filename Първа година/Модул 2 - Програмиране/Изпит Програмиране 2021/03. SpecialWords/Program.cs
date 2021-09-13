using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SpecialWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordCount = int.Parse(Console.ReadLine());

            List<string> special = new List<string>();
            List<string> multipleA = new List<string>();
            List<string> notSpecial = new List<string>();

            for (int i = 0; i < wordCount; i++)
            {
                string word = Console.ReadLine();

                int aCount = word.Count(letter => letter == 'a' || letter == 'A');

                if (word.First() == word.Last())
                {
                    special.Add(word);
                }

                if (aCount > 1)
                {
                    multipleA.Add(word);
                }

                if (word.First() != word.Last() && aCount <= 1)
                {
                    notSpecial.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", special));
            Console.WriteLine(string.Join(", ", multipleA));
            Console.WriteLine(string.Join(", ", notSpecial));
        }
    }
}
