using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._StrategyPattern
{
    class PersonComp1 : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);

            if (result == 0)
            {
                result = x.Name.ToUpper().First().CompareTo(y.Name.ToUpper().First());
            }

            return result;
        }
    }
}
