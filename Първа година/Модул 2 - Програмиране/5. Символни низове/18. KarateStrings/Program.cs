using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.KarateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder inputString = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '>')
                {
                    int power = int.Parse(inputString[i + 1].ToString());

                    if (inputString[i + 2] != '>')
                    {
                        inputString.Remove(i + 1, power);
                    }
                    else
                    {
                        inputString.Remove(i + 1, 1);
                        power--;
                        power += int.Parse(inputString[i + 2].ToString());
                        inputString.Remove(i + 2, power);
                        i++;
                    }
                }
            }

            Console.WriteLine(inputString);
        }
    }
}
