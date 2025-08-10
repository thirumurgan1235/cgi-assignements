using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            int[] arr1 = { 5, 3, -6, -4, 10, 2 };
            int[] arr2 = { 1, 2, 3 };
            int[] arr3 = { -1, -3 };

            Console.WriteLine("Result 1: " + sol.solution(arr1));
            Console.WriteLine("Result 2: " + sol.solution(arr2)); 
            Console.WriteLine("Result 3: " + sol.solution(arr3));
        }
    }
}
