using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_8
{
    internal class Operations
    {
        public static int Sum(params int?[] numbers)
        {
            int total = 0;
            foreach (var n in numbers)
            {
                int value = n ?? 10;
                total += value;
            }
            return total;
        }

        public static int Subtract(int? a, int? b)
        {
            return (a ?? 10) - (b ?? 10);
        }

        public static int Product(params int?[] numbers)
        {
            int result = 1;
            foreach (var n in numbers)
            {
                int value = n ?? 10;
                result *= value;
            }
            return result;
        }

        public static int Min(params int?[] numbers)
        {
            List<int> temp = new List<int>();
            foreach (var n in numbers)
            {
                temp.Add(n ?? 10);
            }
            return temp.Min();
        }

        public static int Max(params int?[] numbers)
        {
            List<int> temp = new List<int>();
            foreach (var n in numbers)
            {
                temp.Add(n ?? 10);
            }
            return temp.Max();
        }

        public static bool IsEven(int? n)
        {
            return (n ?? 10) % 2 == 0;
        }

        public static bool IsOdd(int? n)
        {
            return (n ?? 10) % 2 != 0;
        }

        public static bool IsPrime(int? n)
        {
            int num = n ?? 10;
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
