using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader words = new StreamReader("../../../words.txt");

            StreamReader text = new StreamReader("../../../text.txt");

            StreamWriter result = new StreamWriter("../../../result.txt");

            using (words)
            {
                using (text)
                {
                    using (result)
                    {
                        Dictionary<string, int> wordCount = new Dictionary<string, int>();

                        foreach (string word in words.ReadToEnd().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries))
                        {
                            if (!wordCount.ContainsKey(word))
                            {
                                wordCount.Add(word, 0);
                            }
                        }

                        Regex onlyLetters = new Regex("[^a-zA-Z0-9 ']");

                        string line = text.ReadLine();

                        while (line != null)
                        {
                            line = onlyLetters.Replace(line, " ");

                            string[] lineWords = line.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                            foreach (string lineWord in lineWords)
                            {
                                if (wordCount.ContainsKey(lineWord))
                                {
                                    wordCount[lineWord]++;
                                }
                            }

                            line = text.ReadLine();
                        }

                        foreach (KeyValuePair<string, int> word in wordCount.OrderByDescending(w => w.Value))
                        {
                            result.WriteLine($"{word.Key} - {word.Value}");
                        }
                    }
                }
            }
        }
    }
}
