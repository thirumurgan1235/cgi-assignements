using NUnit.Framework.Legacy;

namespace TestProject2
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void CountCharacters_ShouldReturnCorrectLength()
        {
            int count = Class1.CountCharacters("hello world");
            ClassicAssert.AreEqual(11, count);
        }

        [Test]
        public void IsPalindrome_ShouldReturnTrueForPalindrome()
        {
            bool result = Class1.IsPalindrome("madam");
            ClassicAssert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_ShouldReturnFalseForNonPalindrome()
        {
            bool result = Class1.IsPalindrome("hello");
            ClassicAssert.IsFalse(result);
        }

        [Test]
        public void ReverseSentence_ShouldReturnReversedString()
        {
            string reversed = Class1.ReverseSentence("hello");
            ClassicAssert.AreEqual("olleh", reversed);
        }

        [Test]
        public void CountCharactersDetails_ShouldReturnCorrectCounts()
        {
            Class1.CountCharactersDetails("Hello 123!", out int vowels, out int consonants, out int digits, out int specials);
            ClassicAssert.AreEqual(2, vowels);       // e, o
            ClassicAssert.AreEqual(3, consonants);   // h, l, l
            ClassicAssert.AreEqual(3, digits);       // 1, 2, 3
            ClassicAssert.AreEqual(1, specials);     // !
        }

        [Test]
        public void ToUpperCase_ShouldReturnUpperCase()
        {
            string upper = Class1.ToUpperCase("hello");
            ClassicAssert.AreEqual("HELLO", upper);
        }

        [Test]
        public void ToProperCase_ShouldCapitalizeWords()
        {
            string result = Class1.ToProperCase("hello world");
            ClassicAssert.AreEqual("Hello World", result);
        }

        [Test]
        public void Combine_ShouldMergeTwoSentences()
        {
            string combined = Class1.Combine("Hello", "World");
            ClassicAssert.AreEqual("Hello World", combined);
        }

        [Test]
        public void RemoveExtraSpaces_ShouldTrimAndReduceSpaces()
        {
            string result = Class1.RemoveExtraSpaces("  Hello   World  ");
            ClassicAssert.AreEqual("Hello World", result);
        }

        [Test]
        public void CountWords_ShouldReturnCorrectWordCount()
        {
            int count = Class1.CountWords("   Hello   World  ");
            ClassicAssert.AreEqual(2, count);
        }

        [Test]
        public void ContainsSubstring_ShouldReturnTrueIfSubstringExists()
        {
            bool result = Class1.ContainsSubstring("Hello World", "lo");
            ClassicAssert.IsTrue(result);
        }

        [Test]
        public void CountSubstringOccurrences_ShouldReturnCorrectCount()
        {
            int count = Class1.CountSubstringOccurrences("lollipop", "lo");
            ClassicAssert.AreEqual(1, count);
        }


    }
}
