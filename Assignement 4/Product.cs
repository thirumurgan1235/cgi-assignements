using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_4
{
    internal class Product
    {
        public string PCode;
        public string PName;
        public int QtyInStock;
        public double Price;
        public double DiscountAllowed;
        public static string Brand = "TataElectro";

        public Product(string code, string name, int qty, double price, double discount)
        {
            PCode = code;
            PName = name;
            QtyInStock = qty;
            Price = price;
            DiscountAllowed = discount;
        }

        public void Display()
        {
            Console.WriteLine($"Code: {PCode} | Name: {PName} | Brand: {Brand} | Stock: {QtyInStock} | Price: {Price} | Discount: {DiscountAllowed}%");
        }

        public void ReduceStock(int qty)
        {
            QtyInStock -= qty;
        }

        public double CalculateTotal(int qty)
        {
            double amount = Price * qty;
            double offerDiscount = 0.5; 
            return amount * (1 - offerDiscount);
        }
    }
}
