using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class OnContractEmployee : Employee
    {

        public string ContractDate;
        public int Duration;
        public double Charges;

        public OnContractEmployee(int id, string name, string manager, string contractDate, int duration, double charges)
            : base(id, name, manager)
        {
            ContractDate = contractDate;
            Duration = duration;
            Charges = charges;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"[Contract] Contract Date: {ContractDate}, Duration: {Duration} months, Charges: ₹{Charges}");
        }
    }
}
