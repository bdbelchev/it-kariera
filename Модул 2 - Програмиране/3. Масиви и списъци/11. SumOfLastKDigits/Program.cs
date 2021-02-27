using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _11.SumOfLastKDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            array[0] = 1;

            for (int i = 1; i < n; i++)
            {
                if (i < k)
                {
                    int[] tempArray = new int[i];
                    Array.Copy(array, 0, tempArray, 0, i);
                    array[i] = tempArray.Sum();
                }
                else
                {
                    int[] tempArray = new int[k];
                    Array.Copy(array, i - k, tempArray, 0, k);
                    array[i] = tempArray.Sum();
                }
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
