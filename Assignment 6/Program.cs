using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> orders = new List<Pizza>();
            orders.Add(new Pizza("Small", 2, 1, 1));
            orders.Add(new Pizza("Medium", 1, 2, 0));
            orders.Add(new Pizza("Large", 3, 3, 2));

            Console.WriteLine("=== Pizza Orders ===\n");
            foreach (Pizza p in orders)
            {
                Console.WriteLine(p.GetDescription());
            }

            Console.WriteLine($"\nTotal Pizzas Ordered: {orders.Count}");
        }
    }
    }