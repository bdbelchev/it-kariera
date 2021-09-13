using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GetBiggerValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int int1 = int.Parse(Console.ReadLine());
                    int int2 = int.Parse(Console.ReadLine());
                    int intMax = GetMax(int1, int2);
                    Console.WriteLine(intMax);
                    break;
                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());
                    char charMax = GetMax(char1, char2);
                    Console.WriteLine(charMax);
                    break;
                case "string":
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    string strMax = GetMax(str1, str2);
                    Console.WriteLine(strMax);
                    break;
            }
        }

        private static int GetMax(int int1, int int2)
        {
            return int1 > int2 ? int1 : int2;
        }

        private static char GetMax(char char1, char char2)
        {
            return char1 > char2 ? char1 : char2;
        }

        private static string GetMax(string str1, string str2)
        {
            return str1.CompareTo(str2) >= 0 ? str1 : str2;
        }
    }
}
