using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            Console.WriteLine(sol.solution(new int[] { 5, 3, -6, -4, 10, 2 })); 
            Console.WriteLine(sol.solution(new int[] { 1, 2, 3 })); 
            Console.WriteLine(sol.solution(new int[] { -1, -3 })); 
            Console.WriteLine(sol.solution(new int[] { 1, 2, 0, -3, 8 })); 
            Console.WriteLine(sol.solution(new int[] { 1, 2, 3, -3, 8 }));
        }
    }
}
