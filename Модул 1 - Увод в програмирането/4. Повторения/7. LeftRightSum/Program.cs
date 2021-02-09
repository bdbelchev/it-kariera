using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LeftRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                rightSum += int.Parse(Console.ReadLine());
            }

            int diff = Math.Abs(leftSum - rightSum);
            Console.WriteLine(diff == 0 ? $"Yes, sum = {leftSum}" : $"No, diff = {diff}");
        }
    }
}
