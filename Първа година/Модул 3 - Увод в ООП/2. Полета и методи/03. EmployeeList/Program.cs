using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EmployeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Employee>> company = new Dictionary<string, List<Employee>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                string name = input[0];
                double salary = double.Parse(input[1]);
                string occupation = input[2];
                string division = input[3];
                string email = "n/a";
                int age = -1;

                if (input.Length > 4)
                {
                    if (int.TryParse(input[4], out int result))
                    {
                        age = result;
                    }
                    else
                    {
                        email = input[4];

                        if (input.Length == 6)
                        {
                            age = int.Parse(input[5]);
                        }
                    }
                }

                Employee employee = new Employee(name, salary, occupation, division, email, age);

                if (!company.ContainsKey(employee.Division))
                {
                    company.Add(employee.Division, new List<Employee>());
                }

                company[employee.Division].Add(employee);
            }

            var bestDivision = company.OrderByDescending(d => d.Value.Average(e => e.Salary)).First();
            List<Employee> bestEmployees = bestDivision.Value.OrderByDescending(e => e.Salary).ToList();

            Console.WriteLine($"Highest Average Salary: {bestDivision.Key}");

            foreach (var employee in bestEmployees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
