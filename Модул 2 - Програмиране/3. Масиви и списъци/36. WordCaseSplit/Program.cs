using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.WordCaseSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitters = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', ' ' };

            List<string> input = Console.ReadLine().Split(splitters, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> upperCase = new List<string>();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (string word in input)
            {
                bool onlyLetters = true;

                foreach (char c in word)
                {
                    if (!char.IsLetter(c))
                    {
                        onlyLetters = false;
                        mixedCase.Add(word);
                        break;
                    }
                }

                if (onlyLetters)
                {
                    if (word.ToUpper() == word)
                    {
                        upperCase.Add(word);
                    }

                    else if (word.ToLower() == word)
                    {
                        lowerCase.Add(word);
                    }

                    else
                    {
                        mixedCase.Add(word);
                    }
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
