using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace _06._ImprovedList
{
    static class Sorter<T> where T : IComparable<T>
    {
        public static UniversalList<T> Sort(UniversalList<T> list)
        {
            UniversalList<T> sortedList = new UniversalList<T>();

            foreach (T t in list.OrderBy(t => t))
            {
                sortedList.Add(t);
            }

            return sortedList;
        }
    }
}
