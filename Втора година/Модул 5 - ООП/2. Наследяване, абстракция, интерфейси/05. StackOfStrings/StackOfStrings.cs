using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._StackOfStrings
{
    class StackOfStrings
    {
        private List<string> data;

        public StackOfStrings()
        {
            this.data = new List<string>();
        }

        public void Push(string item)
        {
            this.data.Add(item);
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                return null;
            }

            string s = this.data[data.Count - 1];
            data.Remove(s);
            return s;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                return null;
            }

            return this.data[data.Count - 1];
        }

        public bool IsEmpty()
        {
            return this.data.Count < 1;
        }
    }
}
