using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._DefineRationalNumber2
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
