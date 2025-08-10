using System.Text.RegularExpressions;

namespace StringFunctions
{
    public class Class1
    {
        public static int CountCharacters(string sentence)
        {
            return sentence.Length;
        }

        // 2. Check for palindrome
        public static bool IsPalindrome(string sentence)
        {
            string cleaned = sentence.Replace(" ", "").ToLower();
            string reversed = ReverseSentence(cleaned);
            return cleaned == reversed;
        }

        // 3. Reverse a sentence
        public static string ReverseSentence(string sentence)
        {
            string reversed = "";
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                reversed += sentence[i];
            }
            return reversed;
        }

        // 4. Count vowels, consonants, integers, special characters
        public static void CountCharactersDetails(string sentence, out int vowels, out int consonants, out int digits, out int specialChars)
        {
            vowels = consonants = digits = specialChars = 0;
            sentence = sentence.ToLower();

            foreach (char c in sentence)
            {
                if ("aeiou".Contains(c))
                    vowels++;
                else if (char.IsLetter(c))
                    consonants++;
                else if (char.IsDigit(c))
                    digits++;
                else if (!char.IsWhiteSpace(c))
                    specialChars++;
            }
        }

        // 5. To upper case
        public static string ToUpperCase(string sentence)
        {
            return sentence.ToUpper();
        }

        // 6. Proper case
        public static string ToProperCase(string sentence)
        {
            string[] words = sentence.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word.Length > 0)
                {
                    words[i] = char.ToUpper(word[0]) + word.Substring(1);
                }
            }
            return string.Join(" ", words);
        }

        // 7. Combine two sentences
        public static string Combine(string sentence1, string sentence2)
        {
            return sentence1 + " " + sentence2;
        }

        // 8. Remove extra spaces
        public static string RemoveExtraSpaces(string sentence)
        {
            return Regex.Replace(sentence, @"\s+", " ").Trim();
        }

        // 9. Count words
        public static int CountWords(string sentence)
        {
            string cleaned = RemoveExtraSpaces(sentence);
            return cleaned.Split(' ').Length;
        }

        // 10. Search substring
        public static bool ContainsSubstring(string sentence, string substring)
        {
            return sentence.Contains(substring);
        }

        // 11. Count occurrences of substring
        public static int CountSubstringOccurrences(string sentence, string substring)
        {
            int count = 0;
            int index = 0;

            while ((index = sentence.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }

            return count;
        }

    }
}
