using NumericFunctions;
using NUnit.Framework.Legacy;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
           ClassicAssert.AreEqual(10, Class1.Add(2, 3, 5));
        }

        [Test]
        public void TestSubtract()
        {
            ClassicAssert.AreEqual(5, Class1.Subtract(10, 5));
        }

        [Test]
        public void TestMultiply()
        {
            ClassicAssert.AreEqual(20, Class1.Multiply(4, 5));
        }

        [Test]
        public void TestDivide()
        {
            ClassicAssert.AreEqual(2.5f, Class1.Divide(5, 2), 0.001);
        }

        [Test]
        public void TestMax()
        {
            ClassicAssert.AreEqual(9, Class1.Max(1, 9, 3, 7));
        }

        [Test]
        public void TestMin()
        {
            ClassicAssert.AreEqual(1, Class1.Min(1, 9, 3, 7));
        }

        [Test]
        public void TestIsEven()
        {
            ClassicAssert.IsTrue(Class1.IsEven(4));
            ClassicAssert.IsFalse(Class1.IsEven(3));
        }

        [Test]
        public void TestIsOdd()
        {
            ClassicAssert.IsTrue(Class1.IsOdd(5));
            ClassicAssert.IsFalse(Class1.IsOdd(2));
        }

        [Test]
        public void TestIsPrime()
        {
            ClassicAssert.IsTrue(Class1.IsPrime(7));
            ClassicAssert.IsFalse(Class1.IsPrime(10));
        }

        [Test]
        public void TestReverse()
        {
            ClassicAssert.AreEqual(321, Class1.Reverse(123));
        }
    }
}
