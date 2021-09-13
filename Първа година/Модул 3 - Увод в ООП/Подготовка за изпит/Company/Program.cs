using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static Dictionary<string, Employee> employees = new Dictionary<string, Employee>();
        static Dictionary<string, Company> companies = new Dictionary<string, Company>();

        static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var commandArgs = command.Split(' ').ToArray();

                switch (commandArgs[0])
                {
                    case "AddEmployee":
                        AddEmployee(commandArgs.Skip(1).ToArray());
                        break;
                    case "CreateCompany":
                        CreateCompany(commandArgs.Skip(1).ToArray());
                        break;
                    case "Hire":
                        Hire(commandArgs.Skip(1).ToArray());
                        break;
                    case "Fire":
                        Fire(commandArgs.Skip(1).ToArray());
                        break;
                    case "CalculateSalaries":
                        CalculateSalaries(commandArgs.Skip(1).ToArray());
                        break;
                    case "GetEmployeeWithHighestSalary":
                        GetEmployeeWithHighestSalary(commandArgs.Skip(1).ToArray());
                        break;
                    case "CheckEmployeeIsHired":
                        CheckEmployeeIsHired(commandArgs.Skip(1).ToArray());
                        break;
                    case "RenameCompany":
                        RenameCompany(commandArgs.Skip(1).ToArray());
                        break;
                    case "FireAllEmployees":
                        FireAllEmployees(commandArgs.Skip(1).ToArray());
                        break;
                    case "EmployeeInfo":
                        EmployeeInfo(commandArgs.Skip(1).ToArray());
                        break;
                    case "CompanyInfo":
                        CompanyInfo(commandArgs.Skip(1).ToArray());
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }

        }

        private static void CompanyInfo(string[] v)
        {
            string compName = v[0];

            if (!companies.ContainsKey(compName))
            {
                Console.WriteLine("Could not get CompanyInfo");
                return;
            }
            Company company = companies[compName];
            Console.WriteLine(company);
        }

        private static void EmployeeInfo(string[] v)
        {
            string empName = v[0];

            if (!employees.ContainsKey(empName))
            {
                Console.WriteLine("Could not get EmployeeInfo");
                return;
            }
            Employee employee = employees[empName];
            Console.WriteLine(employee);
        }

        private static void FireAllEmployees(string[] v)
        {
            string compName = v[0];

            if (!companies.ContainsKey(compName))
            {
                Console.WriteLine("Could not FireAllEmployees");
                return;
            }
            Company company = companies[compName];

            company.FireAllEmployees();
        }

        private static void RenameCompany(string[] v)
        {
            string compName = v[0];
            string newName = v[1];

            if (!companies.ContainsKey(compName))
            {
                Console.WriteLine("Could not RenameCompany");
                return;
            }
            Company company = companies[compName];

            try
            {
                company.RenameCompany(newName);
                companies.Remove(compName);
                companies.Add(newName, company);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CheckEmployeeIsHired(string[] v)
        {
            string empName = v[0];
            string compName = v[1];

            if (!companies.ContainsKey(compName))
            {
                Console.WriteLine("Could not CheckEmployeeIsHired");
                return;
            }
            Company company = companies[compName];

            if (company.CheckEmployeeIsHired(empName))
            {
                Console.WriteLine($"Employee {empName} is hired");
            }
            else
            {
                Console.WriteLine($"Employee {empName} is NOT hired");
            }
        }

        private static void GetEmployeeWithHighestSalary(string[] v)
        {
            string compName = v[0];

            if (!companies.ContainsKey(compName))
            {
                Console.WriteLine("Could not GetEmployeeWithHighestSalary");
                return;
            }
            Company company = companies[compName];

            Console.WriteLine(company.GetEmployeeWithHighestSalary());
        }

        private static void CalculateSalaries(string[] v)
        {
            string compName = v[0];

            if (!companies.ContainsKey(compName))
            {
                Console.WriteLine("Could not CalculateSalaries");
                return;
            }
            Company company = companies[compName];

            Console.WriteLine(company.CalculateSalaries());
        }

        private static void Fire(string[] v)
        {
            string empName = v[0];
            string compName = v[1];

            if (!companies.ContainsKey(compName) || !employees.ContainsKey(empName))
            {
                Console.WriteLine("Could not fire employee");
                return;
            }

            Employee emp = employees[empName];
            Company company = companies[compName];
            if (company.Fire(emp))
            {
                Console.WriteLine($"Fired employee {empName}");
            }
            else
            {
                Console.WriteLine($"Did not fire employee {empName}");
            }
        }

        private static void Hire(string[] v)
        {
            string empName = v[0];
            string compName = v[1];

            if (!companies.ContainsKey(compName) || !employees.ContainsKey(empName))
            {
                Console.WriteLine("Could not hire employee");
                return;
            }
            Employee emp = employees[empName];
            Company company = companies[compName];
            company.Hire(emp);
        }

        private static void CreateCompany(string[] v)
        {
            string name = v[0];

            try
            {
                Company company = new Company(name);
                companies.Add(name, company);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private static void AddEmployee(string[] v)
        {
            string name = v[0];
            double salary = double.Parse(v[1]);

            try
            {
                Employee employee = new Employee(name, salary);
                employees.Add(name, employee);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
