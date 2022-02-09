using System;
using System.IO;

namespace _02._LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader("../../../text.txt");

            StreamWriter output = new StreamWriter("../../../output.txt");

            using (input)
            {
                using (output)
                {
                    int line = 1;
                    string lineText = input.ReadLine();

                    while (lineText != null)
                    {
                        output.WriteLine($"Line {line}: {lineText}");
                        line++;
                        lineText = input.ReadLine();
                    }
                }
            }
        }
    }
}
