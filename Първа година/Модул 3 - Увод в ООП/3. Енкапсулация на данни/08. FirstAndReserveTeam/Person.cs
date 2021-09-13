using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.FirstAndReserveTeam
{
    class Person
    {
        private double salary;
        private int age;
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName, int age, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public int Age
        {
            get { return age; }
        }
    }
}
