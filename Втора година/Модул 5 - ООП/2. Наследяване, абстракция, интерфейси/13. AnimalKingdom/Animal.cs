using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._AnimalKingdom
{
    abstract class Animal : IMakeNoise, IMakeTrick
    {
        private string name;
        private int age;

        protected Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string MakeNoise()
        {
            return $"My name is {name}. I am {age} years old.";
        }

        public virtual string MakeTrick()
        {
            return "Look at my trick!";
        }
    }
}
