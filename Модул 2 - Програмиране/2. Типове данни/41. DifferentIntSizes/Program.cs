using System;

namespace _41.DifferentIntSizes
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            if (long.TryParse(number, out _))
            {
                Console.WriteLine($"{number} can fit in:");
            }

            try
            {
                sbyte.Parse(number);
                Console.WriteLine("* sbyte");
            }
            catch
            {
            }
            try
            {
                byte.Parse(number);
                Console.WriteLine("* byte");
            }
            catch
            {
            }
            try
            {
                short.Parse(number);
                Console.WriteLine("* short");
            }
            catch
            {
            }
            try
            {
                ushort.Parse(number);
                Console.WriteLine("* ushort");
            }
            catch
            {
            }
            try
            {
                int.Parse(number);
                Console.WriteLine("* int");
            }
            catch
            {
            }
            try
            {
                uint.Parse(number);
                Console.WriteLine("* uint");
            }
            catch
            {
            }
            try
            {
                long.Parse(number);
                Console.WriteLine("* long");
            }
            catch
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
