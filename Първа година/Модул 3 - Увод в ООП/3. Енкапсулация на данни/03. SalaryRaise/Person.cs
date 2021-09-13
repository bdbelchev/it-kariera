using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SalaryRaise
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

        public void IncreaseSalary(double bonus)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * bonus / 100;
            }
            else
            {
                this.salary += this.salary * bonus / 200;
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} get {this.salary:f2} leva";
        }
    }
}
