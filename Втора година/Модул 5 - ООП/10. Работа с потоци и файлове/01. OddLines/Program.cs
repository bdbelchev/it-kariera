using System;
using System.ComponentModel;
using System.IO;

namespace _01._OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("../../../text.txt");

            using (file)
            {
                int line = 0;
                string lineText = file.ReadLine();

                while (lineText != null)
                {
                    if (line % 2 != 0)
                    {
                        Console.WriteLine(lineText);
                    }

                    line++;
                    lineText = file.ReadLine();
                }
            }
        }
    }
}
