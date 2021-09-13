using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace _07.BalancedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] fullArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] arr1 = fullArray.Take(length / 2).OrderBy(i => i).ToArray();
            int[] arr2 = fullArray.Skip(length / 2).OrderByDescending(i => i).ToArray();

            int[] newArray = new int[length];

            arr1.CopyTo(newArray, 0);
            arr2.CopyTo(newArray, length / 2);

            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
