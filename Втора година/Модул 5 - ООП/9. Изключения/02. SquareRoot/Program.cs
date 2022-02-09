using System;

namespace _02._SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(GetNumber());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

        private static double GetNumber()
        {
            if (double.TryParse(Console.ReadLine(), out double n))
            {
                if (n < 0)
                {
                    throw new ArgumentException("Invalid number");
                }

                return Math.Sqrt(n);
            }

            throw new ArgumentException("Invalid number");
        }
    }
}
