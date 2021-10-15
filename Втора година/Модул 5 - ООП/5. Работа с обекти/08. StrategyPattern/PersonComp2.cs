using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._StrategyPattern
{
    class PersonComp2 : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
