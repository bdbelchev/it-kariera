using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Company
    {
        private string name;
        private List<Employee> employees;

        public Company(string name)
        {
            this.Name = name;
            employees = new List<Employee>();
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

        public void Hire(Employee employee)
        {
            employees.Add(employee);
        }

        public bool Fire(Employee employee)
        {
            return employees.Remove(employee);
        }

        public double CalculateSalaries()
        {
            return employees.Sum(e => e.Salary);
        }

        public void RenameCompany(string newName)
        {
            this.Name = newName;
        }

        public void FireAllEmployees()
        {
            employees.Clear();
        }

        public Employee GetEmployeeWithHighestSalary()
        {
            return employees.OrderByDescending(e => e.Salary).First();
        }

        public bool CheckEmployeeIsHired(string name)
        {
            return employees.Any(e => e.Name == name);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Company {name} has {employees.Count} employees and they are:")
                .AppendLine();

            if (employees.Count < 1)
            {
                sb.Append("N/A");
            }
            else
            {
                sb.Append(string.Join(Environment.NewLine, employees));
            }

            return sb.ToString();
        }
    }
}
