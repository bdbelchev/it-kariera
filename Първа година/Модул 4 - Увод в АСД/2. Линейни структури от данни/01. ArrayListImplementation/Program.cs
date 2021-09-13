using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> list = new ArrayList<int>();
            list.Add(5);
            list[0] = list[0] + 1;
            int element = list.RemoveAt(0);

            list.Add(6);
            list.Add(8);
            list.Add(4);
            list.Add(2);
            list.Add(9);
            list.Add(3);

            list.RemoveAt(3);
            list.RemoveAt(3);
            list.RemoveAt(0);
            list.RemoveAt(1);
        }
    }
}
