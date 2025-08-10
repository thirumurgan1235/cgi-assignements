using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Product
    {
        private readonly string pcode;
        private string pname;
        private int qty_in_stock;
        private double discount_allowed;
        public static string brand;

        public Product(string code)
        {
            pcode = code;
        }

        public void TakeInputFromAdmin()
        {
            Console.Write("Enter Product Name: ");
            pname = Console.ReadLine();

            Console.Write("Enter Quantity in Stock: ");
            qty_in_stock = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Discount Allowed (%): ");
            discount_allowed = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nProduct Details:");
            Console.WriteLine("Code        : " + pcode);
            Console.WriteLine("Name        : " + pname);
            Console.WriteLine("Brand       : " + brand);
            Console.WriteLine("In Stock    : " + qty_in_stock);
            Console.WriteLine("Discount    : " + discount_allowed + "%");
        }
    }
}
