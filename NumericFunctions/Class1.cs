namespace NumericFunctions
{
    public class Class1
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        // 2. Subtract two numbers
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        // 3. Multiply two numbers
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        // 4. Divide two numbers (float)
        public static float Divide(float a, float b)
        {
            if (b != 0)
                return a / b;
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }

        // 5. Max of multiple numbers
        public static int Max(params int[] numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        // 6. Min of multiple numbers
        public static int Min(params int[] numbers)
        {
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        // 7. Check even
        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        // 8. Check odd
        public static bool IsOdd(int n)
        {
            return n % 2 != 0;
        }

        // 9. Check prime
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        // 10. Display all even numbers in a range
        public static void ShowEven(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (IsEven(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // 11. Display all odd numbers in a range
        public static void ShowOdd(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (IsOdd(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // 12. Display all prime numbers in a range
        public static void ShowPrimes(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // 13. Display table of entered number
        public static void ShowTable(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

        // 14. Display tables from 1 to 10 of all numbers in range
        public static void ShowAllTables(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"Table of {i}:");
                ShowTable(i);
                Console.WriteLine();
            }
        }

        // 15. Display tables from a given range (1-5) of numbers in a given range (2-4)
        public static void ShowTablesInRange(int startNo, int endNo, int from, int to)
        {
            for (int i = startNo; i <= endNo; i++)
            {
                Console.WriteLine($"Table of {i}:");
                for (int j = from; j <= to; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }

        // 16. Reverse a number
        public static int Reverse(int n)
        {
            int rev = 0;
            while (n > 0)
            {
                int digit = n % 10;
                rev = rev * 10 + digit;
                n = n / 10;
            }
            return rev;
        }

    }
}
