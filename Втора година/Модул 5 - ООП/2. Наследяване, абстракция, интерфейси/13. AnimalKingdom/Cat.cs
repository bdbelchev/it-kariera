using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._AnimalKingdom
{
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override string MakeNoise()
        {
            return "Meow!\n" + base.MakeNoise();
        }

        public override string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }
    }
}
