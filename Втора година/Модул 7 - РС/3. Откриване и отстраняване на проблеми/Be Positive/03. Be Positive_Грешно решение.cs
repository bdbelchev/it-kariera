using System.Linq;

namespace BePositive
{
    using System;
    using System.Collections.Generic;

    public class BePositiveMain
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); //added option to remove empty entries, convert to list of ints automatically

                //List<int> numbers = new List<int>();

                //for (int j = 0; j < input.Length; j++)
                //{
                //    if (!input[j].Equals(string.Empty))
                //    {
                //        int num = int.Parse(input[j]); //j instead of i
                //        numbers.Add(num);
                //    }
                //} - quite unnecessary :)

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0) //0 included
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else
                    {
                        currentNum += numbers[j++ + 1]; //skip added number

                        if (currentNum >= 0) //0 included
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }
                    }
                }

                if (!found)
                {
                    Console.WriteLine("(empty)");
                }

                Console.WriteLine(); //no newline -> ugly output
            }
        }
    }
}