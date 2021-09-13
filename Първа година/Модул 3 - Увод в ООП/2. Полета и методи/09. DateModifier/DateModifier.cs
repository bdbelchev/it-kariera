using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.DateModifier
{
    class DateModifier
    {
        public int DateDifference(string string1, string string2)
        {
            DateTime date1 = DateTime.Parse(string1);
            DateTime date2 = DateTime.Parse(string2);

            return Math.Abs(date1.Subtract(date2).Days);
        }
    }
}
