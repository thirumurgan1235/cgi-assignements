using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product.brand = "Samsung";

            Product p1 = new Product("P001");
            p1.TakeInputFromAdmin();

            Product p2 = new Product("P002");
            p2.TakeInputFromAdmin();

            p1.DisplayDetails();
            p2.DisplayDetails();
        }
    }
}
