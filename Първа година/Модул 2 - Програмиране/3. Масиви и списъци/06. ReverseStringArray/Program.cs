using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            //Console.WriteLine(string.Join(" ", arr.Reverse()));

            for (int i = 0; i < arr.Length / 2; i++)
            {
                string temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
