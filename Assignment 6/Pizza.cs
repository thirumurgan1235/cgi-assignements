using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Pizza
    {
        private string size;
        private int cheeseToppings;
        private int pepperoniToppings;
        private int hamToppings;

        // Constructor
        public Pizza(string size, int cheese, int pepperoni, int ham)
        {
            this.size = size.ToLower(); // normalize input
            this.cheeseToppings = cheese;
            this.pepperoniToppings = pepperoni;
            this.hamToppings = ham;
        }

        // Public properties (get/set)
        public string Size
        {
            get { return size; }
            set { size = value.ToLower(); }
        }

        public int CheeseToppings
        {
            get { return cheeseToppings; }
            set { cheeseToppings = value; }
        }

        public int PepperoniToppings
        {
            get { return pepperoniToppings; }
            set { pepperoniToppings = value; }
        }

        public int HamToppings
        {
            get { return hamToppings; }
            set { hamToppings = value; }
        }

        // Method to calculate cost
        public double CalcCost()
        {
            double basePrice = 0;

            if (size == "small")
                basePrice = 10;
            else if (size == "medium")
                basePrice = 12;
            else if (size == "large")
                basePrice = 14;

            int totalToppings = cheeseToppings + pepperoniToppings + hamToppings;
            return basePrice + (2 * totalToppings);
        }

        // Method to get description
        public string GetDescription()
        {
            return $"Size: {size}, Cheese: {cheeseToppings}, Pepperoni: {pepperoniToppings}, Ham: {hamToppings}, Cost: ${CalcCost()}";
        }
    }
}
