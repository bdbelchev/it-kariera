using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._IndivisibleFraction
{
    class RationalNumber
    {
        private int numerator;
        private int denumerator;

        public RationalNumber(int numerator, int denumerator)
        {
            this.numerator = numerator;
            this.denumerator = denumerator;
        }

        public int BiggestDivider()
        {
            int a = numerator;
            int b = denumerator;

            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }

            return a;
        }

        public static RationalNumber Convert(RationalNumber num)
        {
            int nod = num.BiggestDivider();

            return new RationalNumber(num.numerator / nod, num.denumerator / nod);
        }

        public override string ToString()
        {
            return $"{numerator}/{denumerator}";
        }
    }
}
