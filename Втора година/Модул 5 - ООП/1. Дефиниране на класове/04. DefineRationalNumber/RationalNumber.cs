using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._DefineRationalNumber
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

        public override string ToString()
        {
            return $"{numerator}/{denumerator}";
        }
    }
}
