using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._RandomList
{
    class RandomList : ArrayList
    {
        public string RandomString()
        {
            if (Count < 1)
            {
                return null;
            }

            Random random = new Random();
            int i = random.Next(0, this.Count);

            string s = this[i].ToString();

            this.RemoveAt(i);

            return s;
        }
    }
}
