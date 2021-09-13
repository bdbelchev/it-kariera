using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char splitter = char.Parse(Console.ReadLine());
            string evenOdd = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = "";

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();

                if (evenOdd == "odd")
                {
                    if (i % 2 == 0)
                    {
                        if (i == 0)
                        {
                            result += s;
                        }
                        else
                        {
                            result += splitter + s;
                        }
                    }
                }
                else if (evenOdd == "even")
                {
                    if (i % 2 != 0)
                    {
                        if (i == 1)
                        {
                            result += s;
                        }
                        else
                        {
                            result += splitter + s;
                        }
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
