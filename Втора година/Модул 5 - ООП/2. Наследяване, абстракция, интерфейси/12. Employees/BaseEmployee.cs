using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._Employees
{
    abstract class BaseEmployee
    {
        private string employeeID;
        private string employeeName;
        private string employeeAddress;

        protected BaseEmployee(string id, string name, string address)
        {
            employeeID = id;
            employeeName = name;
            employeeAddress = address;
        }

        public virtual void Show()
        {
            Console.WriteLine($"ID: {employeeID}\nName: {employeeName}\nAddress: {employeeAddress}");
        }

        public abstract double CalculateSalary(int workingHours);

        public abstract string GetDepartment();
    }
}
