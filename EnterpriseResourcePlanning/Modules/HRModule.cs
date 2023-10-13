using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterpriseResourcePlanning.Models;

namespace EnterpriseResourcePlanning.Modules
{
    //Abstraction
    public class HRModule: Module //Inheritance
    {
        //Encapsulation
        private readonly List<Employee> employees;

        public HRModule(): base("Human Resource")
        {
            employees = new List<Employee>();   
        }

        //Polymorphism
        public override void Run()
        {
            base.Run();
            AddEmployee("John", "Smith", "Intern", "Technology");
            AddEmployee("Mary", "Jane", "Senior", "Finance");
        }

        public void AddEmployee(string firstName, string lastName, string position, string department)
        {
            int nextEmployeeId = employees.Count + 1;
            Employee employee = new()
            {
                FirstName = firstName,
                LastName = lastName,
                EmployeeId = nextEmployeeId,
                Position = position,
                Department = department
            };
            employees.Add(employee);
            Console.WriteLine($"Added new employee {employee.FirstName} {employee.LastName}");
        }

        public void ListEmployees()
        {
            foreach(var employee in employees)
            {
                Console.WriteLine($"Employee ID: {employee.EmployeeId}");
                Console.WriteLine($"Employee Name: {employee.FirstName} {employee.LastName}");
            }
        }

        public Employee? SearchEmployeeById(int employeeId)
        {
            return employees.FirstOrDefault(employee => employee.EmployeeId == employeeId);
        }

        public void TerminateEmployee(int employeeId)
        {
            var employee = employees.FirstOrDefault(employee => employee.EmployeeId == employeeId);
            if (employee is null) return;
            employees.Remove(employee);
        }
    }
}
