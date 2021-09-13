using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.SumTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 1; i < numbers.Count;)
            {
                if (i > 0 && numbers[i - 1] == numbers[i])
                {
                    numbers[i] += numbers[i - 1];
                    numbers.RemoveAt(i - 1);

                    //int sum = numbers[i] * 2;
                    //numbers.RemoveRange(i - 1, 2);
                    //numbers.Insert(i - 1, sum);

                    i--;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
