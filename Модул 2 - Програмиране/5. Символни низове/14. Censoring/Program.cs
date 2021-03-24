using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Censoring
{
    class Program
    {
        static void Main(string[] args)
        {
            string bannedWord = Console.ReadLine();
            string sentence = Console.ReadLine();

            while (sentence.Contains(bannedWord))
            {
                sentence = sentence.Replace(bannedWord, new string('*', bannedWord.Length));
            }

            Console.WriteLine(sentence);
        }
    }
}
