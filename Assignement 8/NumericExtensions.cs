using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_8
{
   public static class NumericExtensions
    {
        public static void ShowEvenNumbers(this int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void ShowOddNumbers(this int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void ShowPrimeNumbers(this int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (Operations.IsPrime(i)) // Make sure Operations class has IsPrime as public static
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void ShowTable(this int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

        public static void ShowAllTables1To10(this int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                i.ShowTable(); // fixed: i.ShowTable() works now
                Console.WriteLine();
            }
        }

        public static void ShowTablesInRange(this int startNo, int endNo, int from, int to)
        {
            for (int i = startNo; i <= endNo; i++)
            {
                for (int j = from; j <= to; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }

        public static int ReverseNumber(this int n)
        {
            int rev = 0;
            while (n > 0)
            {
                rev = rev * 10 + n % 10;
                n /= 10;
            }
            return rev;
        }
    }

}

