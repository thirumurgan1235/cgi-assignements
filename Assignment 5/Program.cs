using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new OnContractEmployee(101, "Kumar", "Ravi", "01-01-2024", 12, 25000));
            employees.Add(new OnPayrollEmployee(102, "Anu", "Priya", "10-06-2015", 12, 50000));
            employees.Add(new OnPayrollEmployee(103, "John", "Meena", "05-03-2019", 6, 40000));
            employees.Add(new OnContractEmployee(104, "Sneha", "Ravi", "12-07-2025", 6, 18000));

            foreach (Employee emp in employees)
            {
                emp.Display();
                Console.WriteLine();
            }

            Console.WriteLine("Total Employees: " + employees.Count);
        }
    }
    }
