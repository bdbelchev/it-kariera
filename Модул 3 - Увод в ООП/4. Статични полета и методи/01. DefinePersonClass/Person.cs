using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefinePersonClass
{
    class Person
    {
        private string name;
        private int age;
        private static int counter;

        public Person()
        {
            counter++;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static int Counter
        {
            get { return counter; }
        }
    }
}
