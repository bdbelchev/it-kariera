using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = numbers.Length;
            int k = int.Parse(Console.ReadLine());

            int[] sum = new int[n];

            for (int i = 0; i < k; i++)
            {
                numbers = Rotate(numbers);

                for (int j = 0; j < n; j++)
                {
                    sum[j] += numbers[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }

        private static int[] Rotate(int[] arr)
        {
            int[] rotate = new int[arr.Length];

            rotate[0] = arr[arr.Length - 1];

            for (int j = 1; j < arr.Length; j++)
            {
                rotate[j] = arr[j - 1];
            }

            return rotate;
        }
    }
}
