using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicencePlates
{
    class Program
    {
        static void Main(string[] args)
        {
            string startingLetters = Console.ReadLine();
            string endingLetters = Console.ReadLine();
            int neededNumbers = int.Parse(Console.ReadLine());
            int printedNumbers = 0;

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        for (int l = 0; l <= 9; l++)
                        {
                            if ((i + j + k + l) == i * k - neededNumbers && printedNumbers < neededNumbers)
                            {
                                Console.Write($"{startingLetters}{i}{j}{k}{l}{endingLetters} ");
                                printedNumbers++;
                            }
                        }
                    }
                }
            }
        }
    }
}
