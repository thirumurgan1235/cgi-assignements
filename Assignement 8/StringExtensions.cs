using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_8
{
    public static class StringExtensions
    {
        public static int CharCount(this string str)
        {
            return (str ?? "***").Length;
        }

        public static bool IsPalindrome(this string str)
        {
            str = (str ?? "***").ToLower().Replace(" ", "");
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return str == new string(arr);
        }

        public static string ReverseSentence(this string str)
        {
            char[] arr = (str ?? "***").ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static void CountAllCharacters(this string str)
        {
            str = str ?? "***";
            int vowels = 0, consonants = 0, digits = 0, special = 0;

            foreach (char c in str.ToLower())
            {
                if ("aeiou".Contains(c)) vowels++;
                else if (Char.IsLetter(c)) consonants++;
                else if (Char.IsDigit(c)) digits++;
                else if (!Char.IsWhiteSpace(c)) special++;
            }

            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}, Digits: {digits}, Special Characters: {special}");
        }

        public static string ToProperCase(this string str)
        {
            str = str ?? "***";
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        public static string CombineWith(this string str1, string str2)
        {
            str1 = str1 ?? "***";
            str2 = str2 ?? "***";
            return str1 + " " + str2;
        }

        public static string RemoveExtraSpaces(this string str)
        {
            return string.Join(" ", (str ?? "***").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        public static int WordCount(this string str)
        {
            return (str ?? "***").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool ContainsSubstring(this string str, string substr)
        {
            return (str ?? "***").Contains(substr ?? "***");
        }

        public static int CountOccurrences(this string str, string substr)
        {
            str = str ?? "***";
            substr = substr ?? "***";

            int count = 0, pos = 0;
            while ((pos = str.IndexOf(substr, pos)) != -1)
            {
                count++;
                pos += substr.Length;
            }
            return count;
        }
    }
}
