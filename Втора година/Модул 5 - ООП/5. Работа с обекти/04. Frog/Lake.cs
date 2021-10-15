using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Frog
{
    class Lake : IEnumerable<int>
    {
        private int[] stones;

        public Lake(int[] stones)
        {
            int[] evenStones = stones.Where(s => s % 2 == 0).OrderByDescending(s => s).ToArray();
            int[] unevenStones = stones.Where(s => s % 2 != 0).OrderBy(s => s).ToArray();
            this.stones = unevenStones.Concat(evenStones).ToArray();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>) stones).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
