using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgi_assignements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            int a = 10, b = 5;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);

            int x = 8, y = 4;
            char op = '*';
            if (op == '+') Console.WriteLine(x + y);
            else if (op == '-') Console.WriteLine(x - y);
            else if (op == '*') Console.WriteLine(x * y);
            else if (op == '/') Console.WriteLine(x / y);
            else Console.WriteLine("Invalid");

            for (int i = 1; i <= 10; i++)
                Console.WriteLine("Thirumurugan");

            for (int i = 2; i <= 20; i += 2)
                Console.Write(i + " ");
            Console.WriteLine();

            int j = 2;
            while (j <= 20)
            {
                Console.Write(j + " ");
                j += 2;
            }
            Console.WriteLine();

            int k = 2;
            do
            {
                Console.Write(k + " ");
                k += 2;
            } while (k <= 20);
            Console.WriteLine();

            for (int i = 1; i < 20; i += 2)
                Console.Write(i + " ");
            Console.WriteLine();

            j = 1;
            while (j < 20)
            {
                Console.Write(j + " ");
                j += 2;
            }
            Console.WriteLine();

            k = 1;
            do
            {
                Console.Write(k + " ");
                k += 2;
            } while (k < 20);
            Console.WriteLine();

            int n = 6;
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(n + " x " + i + " = " + (n * i));

            j = 1;
            while (j <= 10)
            {
                Console.WriteLine(n + " x " + j + " = " + (n * j));
                j++;
            }

            k = 1;
            do
            {
                Console.WriteLine(n + " x " + k + " = " + (n * k));
                k++;
            } while (k <= 10);

            for (int i = 100; i >= 5; i -= 3)
                Console.Write(i + " ");
            Console.WriteLine();

            int p = 1, q = 2, r = 3;
            Console.WriteLine(p + " " + q + " " + r);

            Console.WriteLine(p);
            Console.WriteLine(q);
            Console.WriteLine(r);
        }
    }
    }
