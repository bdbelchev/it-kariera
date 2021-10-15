using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._EqualityLogic
{
    class Person : IComparable<Person>
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(Person other)
        {
            if (name == other.name && age == other.age)
            {
                return 0;
            }

            return -1;
        }
    }
}
