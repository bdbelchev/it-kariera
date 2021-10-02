using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Animal
{
    class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself()
                    + Environment.NewLine
                    + "DJAAF";
        }
    }
}
