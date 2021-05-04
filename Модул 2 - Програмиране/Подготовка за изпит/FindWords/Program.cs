using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordCount = int.Parse(Console.ReadLine());
            List<string> special = new List<string>();
            List<string> notSpecial = new List<string>();

            for (int i = 0; i < wordCount; i++)
            {
                string word = Console.ReadLine();

                if (word[0].ToString() == word[0].ToString().ToUpper()
                    && (word.Contains("i") || word.Contains("I")) && word.Length > 7)
                {
                    special.Add(word);
                }
                else
                {
                    notSpecial.Add(word);
                }
            }

            Console.WriteLine($"Special words: {string.Join(", ", special)}");
            Console.WriteLine($"Other words: {string.Join(", ", notSpecial)}");
        }
    }
}
