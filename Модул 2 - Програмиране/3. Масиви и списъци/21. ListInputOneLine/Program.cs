using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.ListInputOneLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //"2 8 30 25" ->["2", "8", "30", "25"] -> [2,8,30, 25]
            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();
            //elements: 1, 2, 3, 4, 5, 6
            //indexes: 0, 1, 2, 3, 4, 5
            for (int index = 0; index <= numbers.Count - 1; index++)
            {
                //nums[0] = 1
                Console.WriteLine("nums[" + index + "] = " + numbers[index]);
            }
        }
    }
}