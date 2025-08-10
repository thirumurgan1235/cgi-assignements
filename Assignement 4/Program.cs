using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_4
{
    internal class Program
    {
        public static List<Product> products = new List<Product>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nWho are you?");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");
                int role = Convert.ToInt32(Console.ReadLine());

                if (role == 1)
                {
                    AdminMenu();
                }
                else if (role == 2)
                {
                    CustomerMenu();
                }
                else
                {
                    break;
                }
            }
        }

        public static void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Admin Menu ---");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Display Products");
                Console.WriteLine("3. Back");
                Console.Write("Enter choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());

                if (ch == 1)
                {
                    Console.Write("Enter Product Code: ");
                    string code = Console.ReadLine();

                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Quantity in Stock: ");
                    int qty = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Price per Unit: ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Discount Allowed (%): ");
                    double disc = Convert.ToDouble(Console.ReadLine());

                    products.Add(new Product(code, name, qty, price, disc));
                    Console.WriteLine("✅ Product added successfully.");
                }
                else if (ch == 2)
                {
                    Console.WriteLine("\n--- Product List ---");
                    foreach (Product p in products)
                    {
                        p.Display();
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public static void CustomerMenu()
        {
            Console.WriteLine("\n--- Customer: Order Product ---");

            Console.Write("Enter Product Name: ");
            string pname = Console.ReadLine();

            Product selected = products.FirstOrDefault(p => p.PName.Equals(pname, StringComparison.OrdinalIgnoreCase));

            if (selected == null)
            {
                Console.WriteLine("❌ Product not found.");
                return;
            }

            selected.Display();

            Console.Write("Enter Quantity to Buy: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            if (qty > selected.QtyInStock)
            {
                Console.WriteLine("❌ Not enough stock.");
                return;
            }

            double total = selected.CalculateTotal(qty);
            selected.ReduceStock(qty);

            Console.WriteLine("\n----- BILL -----");
            Console.WriteLine($"Product: {selected.PName}");
            Console.WriteLine($"Quantity: {qty}");
            Console.WriteLine($"MRP/unit: {selected.Price}");
            Console.WriteLine($"Original Total: {selected.Price * qty}");
            Console.WriteLine($"50% Republic Day Discount Applied");
            Console.WriteLine($"Net Total: {total}");
            Console.WriteLine("--------------------");
        }
    }
}
