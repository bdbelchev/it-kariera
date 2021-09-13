using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Employee
    {
        private string name;
        private double salary;

        public Employee(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid name");
                }

                this.name = value;
            }
        }

        public double Salary
        {
            get { return salary; }
            private set
            {
                if (value < 560)
                {
                    throw new ArgumentException("Invalid salary");
                }

                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"Employee: {name} with salary {salary:f2}";
        }
    }
}
