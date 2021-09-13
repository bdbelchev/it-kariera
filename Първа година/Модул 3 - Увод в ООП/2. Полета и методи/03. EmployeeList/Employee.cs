using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EmployeeList
{
    class Employee
    {
        private string name;
        private double salary;
        private string occupation;
        private string division;
        private string email;
        private int age;

        public Employee(string name, double salary, string occupation, string division, string email, int age)
        {
            this.name = name;
            this.salary = salary;
            this.occupation = occupation;
            this.division = division;
            this.email = email;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
        }

        public double Salary
        {
            get { return salary; }
        }

        public string Occupation
        {
            get { return occupation; }
        }

        public string Division
        {
            get { return division; }
        }

        public string Email
        {
            get { return email; }
        }

        public int Age
        {
            get { return age; }
        }
    }
}
