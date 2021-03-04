using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lists = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();

            for (int i = lists.Count - 1; i >= 0; i--)
            {
                foreach (string s in lists[i].Split(' ').ToList())
                {
                    if (s != "")
                    {
                        result.Add(s);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
