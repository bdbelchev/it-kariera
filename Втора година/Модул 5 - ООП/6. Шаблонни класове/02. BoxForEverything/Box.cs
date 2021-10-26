using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._BoxForEverything
{
    class Box<T>
    {
        private T data;

        public Box(T data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            return $"{data.GetType().FullName}: {data}";
        }
    }
}
