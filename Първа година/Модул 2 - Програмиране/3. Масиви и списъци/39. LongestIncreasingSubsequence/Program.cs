using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] len = new int[nums.Count];
            int[] prev = new int[nums.Count];

            for (int p = 0; p < nums.Count; p++)
            {
                len[p] = 1;
                prev[p] = -1;

                for (int i = 0; i <= p - 1; i++)
                {
                    if (nums[i] < nums[p] && len[i] + 1 > len[p])
                    {
                        len[p] = len[i] + 1;
                        prev[p] = i;
                    }
                }
            }

            int index = 0;
            int lastNumber = 0;

            for (int i = prev.Length - 1; i >= 0; i--)
            {
                if (prev[i] >= index)
                {
                    index = prev[i];
                    lastNumber = i;
                }
            }

            List<int> lis = new List<int>();
            lis.Add(nums[lastNumber]);

            while (index != -1)
            {
                lis.Add(nums[index]);
                index = prev[index];
            }

            lis = lis.Distinct().Reverse().ToList();

            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
