using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Employee
    {
        public int ID;
        public string Name;
        public string ReportingManager;

        public Employee(int id, string name, string manager)
        {
            ID = id;
            Name = name;
            ReportingManager = manager;
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Manager: {ReportingManager}");
        }
    }
}
