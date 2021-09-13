using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Google
{
    class Company
    {
        private string name;
        private string division;
        private double salary;

        public Company(string name, string division, double salary)
        {
            this.name = name;
            this.division = division;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"{this.name} {this.division} {this.salary}";
        }
    }
}
