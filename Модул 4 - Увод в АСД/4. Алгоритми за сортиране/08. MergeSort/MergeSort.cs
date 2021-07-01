using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MergeSort
{
    class MergeSort
    {
        public static int[] Sort(int[] array)
        {
            int[] result = new int[array.Length];

            if (array.Length <= 1)
            {
                return array;
            }

            int midPoint = array.Length / 2;
            int[] left = array.Take(midPoint).ToArray();
            int[] right = array.Skip(midPoint).ToArray();

            left = Sort(left);
            right = Sort(right);
            result = Merge(left, right);

            return result;
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult++] = left[indexLeft++];
                    }
                    else
                    {
                        result[indexResult++] = right[indexRight++];
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult++] = left[indexLeft++];
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult++] = right[indexRight++];
                }
            }

            return result;
        }
    }
}
