using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._Employees
{
    class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;
        private string employeeDepartment;

        public FullTimeEmployee(string id, string name, string address, string position, string department) : base(id, name, address)
        {
            employeePosition = position;
            employeeDepartment = department;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Position: {employeePosition}\nDepartment: {employeeDepartment}");
        }

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.8;
        }

        public override string GetDepartment()
        {
            return employeeDepartment;
        }
    }
}
