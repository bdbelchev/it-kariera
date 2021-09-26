using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._Employees
{
    class ContractEmployee : BaseEmployee
    {
        private string employeeTask;
        private string employeeDepartment;

        public ContractEmployee(string id, string name, string address, string task, string department) : base(id, name, address)
        {
            employeeTask = task;
            employeeDepartment = department;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Task: {employeeTask}");
        }

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20;
        }

        public override string GetDepartment()
        {
            return employeeDepartment;
        }
    }
}
