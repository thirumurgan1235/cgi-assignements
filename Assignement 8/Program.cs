using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Sum: " + Operations.Sum(10, null, 20));
                Console.WriteLine("Is 5 Prime? " + Operations.IsPrime(5));

                Console.WriteLine("\nEven numbers from 1 to 10:");
                1.ShowEvenNumbers(10);

                Console.WriteLine("Reverse of 1234: " + 1234.ReverseNumber());

                string sentence = "Hello 123!!!";
                sentence.CountAllCharacters();

                string text = "Madam";
                Console.WriteLine($"Is '{text}' Palindrome? {text.IsPalindrome()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
