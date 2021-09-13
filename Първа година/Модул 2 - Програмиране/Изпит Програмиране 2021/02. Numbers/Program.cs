using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(',').Select(int.Parse).ToList();

            List<int> group1 = input.Where(i => i % 2 == 0).ToList();
            List<int> group2 = input.Where(i => i % 2 != 0).ToList();
            List<int> group3 = new List<int>();

            foreach (int i in input)
            {
                int number = i;
                int sum = 0;

                while (number > 0)
                {
                    int lastDigit = number % 10;
                    sum += lastDigit;
                    number = number / 10;
                }

                if (sum.ToString().EndsWith("5"))
                {
                    group3.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", group1));
            Console.WriteLine(string.Join(", ", group2));
            Console.WriteLine(string.Join(", ", group3));
        }
    }
}
