using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignement_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Customer ID: ");
            string customerId = Console.ReadLine();

            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter Units Consumed: ");
            int units = Convert.ToInt32(Console.ReadLine());

            double chargePerUnit = 0;

            if (units < 200)
                chargePerUnit = 1.20;
            else if (units >= 200 && units < 400)
                chargePerUnit = 1.50;
            else if (units >= 400 && units < 600)
                chargePerUnit = 1.80;
            else
                chargePerUnit = 2.00;

            double amount = units * chargePerUnit;
            double surcharge = 0;

            if (amount > 400)
                surcharge = amount * 0.15;

            double netAmount = amount + surcharge;

            if (netAmount < 100)
                netAmount = 100;

            Console.WriteLine("\nCustomer IDNO : " + customerId);
            Console.WriteLine("Customer Name : " + customerName);
            Console.WriteLine("Unit Consumed : " + units);
            Console.WriteLine("Amount Charges @Rs. " + chargePerUnit.ToString("0.00") + " per unit : " + amount.ToString("0.00"));
            Console.WriteLine("Surcharge Amount : " + surcharge.ToString("0.00"));
            Console.WriteLine("Net Amount Paid By the Customer : " + netAmount.ToString("0.00"));
        }
    }
    }
