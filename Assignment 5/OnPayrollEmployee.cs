using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class OnPayrollEmployee : Employee
    {
        public string JoiningDate;
        public int Experience;
        public double BasicSalary;
        public double DA;
        public double HRA;
        public double PF;
        public double NetSalary;

        public OnPayrollEmployee(int id, string name, string manager, string joiningDate, int experience, double basic)
            : base(id, name, manager)
        {
            JoiningDate = joiningDate;
            Experience = experience;
            BasicSalary = basic;
            CalculateSalary();
        }

        public void CalculateSalary()
        {
            if (Experience > 10)
            {
                DA = 0.10 * BasicSalary;
                HRA = 0.085 * BasicSalary;
                PF = 6200;
            }
            else if (Experience > 7)
            {
                DA = 0.07 * BasicSalary;
                HRA = 0.065 * BasicSalary;
                PF = 4100;
            }
            else if (Experience > 5)
            {
                DA = 0.041 * BasicSalary;
                HRA = 0.038 * BasicSalary;
                PF = 1800;
            }
            else
            {
                DA = 0.019 * BasicSalary;
                HRA = 0.020 * BasicSalary;
                PF = 1200;
            }

            NetSalary = BasicSalary + DA + HRA - PF;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"[Payroll] Join: {JoiningDate}, Exp: {Experience} yrs, Basic: ₹{BasicSalary}");
            Console.WriteLine($"DA: ₹{DA}, HRA: ₹{HRA}, PF: ₹{PF}, Net Salary: ₹{NetSalary}");
        }
    }
}
