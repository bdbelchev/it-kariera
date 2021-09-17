using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._DefineOddNumber
{
    class OddNumber
    {
        private int num;

        public OddNumber(int num)
        {
            this.num = num;
        }

        public override string ToString()
        {
            return this.num.ToString();
        }
    }
}
