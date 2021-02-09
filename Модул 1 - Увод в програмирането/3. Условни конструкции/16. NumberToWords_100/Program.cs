using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.NumberToWords_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstDigit = number / 10;
            int lastDigit = number % 10;

            if (number < 0 || number > 100)
            {
                Console.WriteLine("invalid number");
            }
            else if (number < 20)
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    case 10:
                        Console.WriteLine("ten");
                        break;
                    case 11:
                        Console.WriteLine("eleven");
                        break;
                    case 12:
                        Console.WriteLine("twelve");
                        break;
                    case 13:
                        Console.WriteLine("thirteen");
                        break;
                    case 14:
                        Console.WriteLine("fourteen");
                        break;
                    case 15:
                        Console.WriteLine("fifteen");
                        break;
                    case 16:
                        Console.WriteLine("sixteen");
                        break;
                    case 17:
                        Console.WriteLine("seventeen");
                        break;
                    case 18:
                        Console.WriteLine("eighteen");
                        break;
                    case 19:
                        Console.WriteLine("nineteen");
                        break;
                }

            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                string firstPart = "";
                string secondPart = "";

                switch (firstDigit)
                {
                    case 2:
                        firstPart = "twenty";
                        break;
                    case 3:
                        firstPart = "thirty";
                        break;
                    case 4:
                        firstPart = "forty";
                        break;
                    case 5:
                        firstPart = "fifty";
                        break;
                    case 6:
                        firstPart = "sixty";
                        break;
                    case 7:
                        firstPart = "seventy";
                        break;
                    case 8:
                        firstPart = "eighty";
                        break;
                    case 9:
                        firstPart = "ninety";
                        break;
                }

                switch (lastDigit)
                {
                    case 0:
                        secondPart = "";
                        break;
                    case 1:
                        secondPart = "one";
                        break;
                    case 2:
                        secondPart = "two";
                        break;
                    case 3:
                        secondPart = "three";
                        break;
                    case 4:
                        secondPart = "four";
                        break;
                    case 5:
                        secondPart = "five";
                        break;
                    case 6:
                        secondPart = "six";
                        break;
                    case 7:
                        secondPart = "seven";
                        break;
                    case 8:
                        secondPart = "eight";
                        break;
                    case 9:
                        secondPart = "nine";
                        break;
                }

                Console.WriteLine(lastDigit == 0 ? firstPart : $"{firstPart} {secondPart}");
            }
        }
    }
}
