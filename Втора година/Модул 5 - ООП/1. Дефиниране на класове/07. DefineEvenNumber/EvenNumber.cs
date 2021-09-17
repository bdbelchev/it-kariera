using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._DefineEvenNumber
{
    class EvenNumber
    {
        private int num;

        public EvenNumber(int num)
        {
            this.num = num;
        }

        public override string ToString()
        {
            return this.num.ToString();
        }
    }
}
