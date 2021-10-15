using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "Create":
                        listyIterator = new ListyIterator<string>(input.Skip(1).ToArray());
                        break;
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        listyIterator.Print();
                        break;
                    case "PrintAll":
                        foreach (string s in listyIterator)
                        {
                            Console.Write($"{s} ");
                        }

                        Console.WriteLine();
                        break;
                }

                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
