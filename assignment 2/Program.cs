using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the marks obtained in Physics: ");
            int phy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chem = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Mathematics: ");
            int math = Convert.ToInt32(Console.ReadLine());

            int total = phy + chem + math;
            int mathPhy = math + phy;

            if (math >= 65 && phy >= 55 && chem >= 50 && (total >= 180 || mathPhy >= 140))
                Console.WriteLine("The candidate is eligible for admission.");
            else
                Console.WriteLine("The candidate is not eligible for admission.");
        }
    }
}
