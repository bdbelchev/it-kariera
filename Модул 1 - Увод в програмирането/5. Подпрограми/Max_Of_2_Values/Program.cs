using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Of_2_Values
{
    class Program
    {
        static int GetMax(int first, int second)
        {
            return first >= second ? first : second;
        }

        static char GetMax(char first, char second)
        {
            return first >= second ? first : second;
        }

        static string GetMax(string first, string second)
        {
            return first.CompareTo(second) >= 0 ? first : second;
        }

        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    {
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        int max = GetMax(a, b);
                        Console.WriteLine(max);
                        break;
                    }
                case "char":
                    {
                        char a = char.Parse(Console.ReadLine());
                        char b = char.Parse(Console.ReadLine());
                        char max = GetMax(a, b);
                        Console.WriteLine(max);
                        break;
                    }
                case "string":
                    {
                        string a = Console.ReadLine();
                        string b = Console.ReadLine();
                        string max = GetMax(a, b);
                        Console.WriteLine(max);
                        break;
                    }
            }
        }
    }
}
