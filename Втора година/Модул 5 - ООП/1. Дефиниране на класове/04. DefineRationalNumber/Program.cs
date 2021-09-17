using System;

namespace _04._DefineRationalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber[] numbers = new RationalNumber[3];

            for (int i = 0; i < 3; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());

                RationalNumber number = new RationalNumber(n, d);
                numbers[i] = number;
            }

            foreach (RationalNumber number in numbers)
            {
                Console.WriteLine(number.ToString());
            }
        }
    }
}
