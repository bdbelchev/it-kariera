using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ListMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            list1.Sort();
            list2.Sort();

            List<int> list3 = new List<int>();
            list3.AddRange(list1);
            list3.AddRange(list2.Where(i => !list1.Contains(i)));
            list3.Sort();

            Console.WriteLine(string.Join(" ", list3));
        }
    }
}
