using DotnetIntern2021.OOP;
using NUnit.Framework;
using System;

namespace DotnetIntern2021Test.OOP
{
    public class FractionTests
    {
        [Test]
        public void Test_EqualTo()
        {
            var fraction1 = new Fraction(2, 6);
            var fraction2 = new Fraction(4, 12);
            Assert.AreEqual(fraction1 == fraction2, true);
        }

        [Test]
        public void Test_NotEqualTo()
        {
            var fraction1 = new Fraction(2, 6);
            var fraction2 = new Fraction(4, 12);
            Assert.AreEqual(fraction1 != fraction2, false);
        }

        [Test]
        public void Test_Equals()
        {
            var fraction = new Fraction(3, 10);
            string testString = "3/10";
            Assert.AreEqual(fraction.Equals(testString), false);
        }

        [Test]
        public void Test_ToString()
        {
            var fraction = new Fraction(3, 10);
            string testString = "3/10";
            Assert.AreEqual(fraction.ToString(),testString);
        }

        [Test]
        public void Test_Minimal()
        {
            var fraction = new Fraction(2, 6);
            var answer = new Fraction(1, 3);
            Assert.AreEqual(fraction.Minimal(), answer);
        }
        [Test]
        public void Test_Plus()
        {
            var fraction1 = new Fraction(3, 10);
            var fraction2 = new Fraction(2, 6);
            var answer = new Fraction(19,30);
            Assert.AreEqual(fraction1 + fraction2, answer);
        }
        [Test]
        public void Test_Minus()
        {
            var fraction1 = new Fraction(3, 10);
            var fraction2 = new Fraction(2, 6);
            var answer = new Fraction(1, 30);
            Assert.AreEqual(fraction2 - fraction1, answer);
        }
        [Test]
        public void Test_Multiply()
        {
            var fraction1 = new Fraction(3, 10);
            var fraction2 = new Fraction(2, 6);
            var answer = new Fraction(1, 10);
            Assert.AreEqual(fraction1 * fraction2, answer);
        }
        [Test]
        public void Test_Divide()
        {
            var fraction1 = new Fraction(3, 10);
            var fraction2 = new Fraction(2, 6);
            var answer = new Fraction(9, 10);
            Assert.AreEqual(fraction1 / fraction2, answer);
        }
        [Test]
        public void Test_GreaterThan()
        {
            var fraction1 = new Fraction(3, 10);
            var fraction2 = new Fraction(2, 6);
            Assert.AreEqual(fraction1 > fraction2, false);
        }
        [Test]
        public void Test_LessThan()
        {
            var fraction1 = new Fraction(3, 10);
            var fraction2 = new Fraction(2, 6);
            Assert.AreEqual(fraction1 < fraction2, true);
        }
        [Test]
        public void Test_GreaterOrEqual()
        {
            var fraction1 = new Fraction(3, 10);
            var fraction2 = new Fraction(2, 6);
            Assert.AreEqual(fraction2 >= fraction1, true);
        }
        [Test]
        public void Test_LessOrEqual()
        {
            var fraction1 = new Fraction(2, 6); 
            var fraction2 = new Fraction(4, 12);
            Assert.AreEqual(fraction1 <= fraction2, true);
        }
        [Test]
        public void Test_InverseFraction()
        {
            var fraction = new Fraction(2, 6);
            var answer = new Fraction(3, 1);
            Assert.AreEqual(!fraction, answer);
        }
        [Test]
        public void Test_IntegerToFraction()
        {
            var answer = new Fraction(3, 1);
            Assert.AreEqual((Fraction)answer, answer);
        }
        [Test]
        public void Test_FractionToRealNumber()
        {
            var fraction = new Fraction(1, 4);
            var answer = 0.25;
            Assert.AreEqual((float)fraction, answer);
        }
        [Test]
        public void Test_FractionPlusInteger()
        {
            var fraction = new Fraction(1, 4);
            var integer = 2;
            var answer = new Fraction(9, 4);
            Assert.AreEqual(fraction + integer, answer);
        }
        [Test]
        public void Test_FractionMinusInteger()
        {
            var fraction = new Fraction(1, 4);
            var integer = 2;
            var answer = new Fraction(-7, 4);
            Assert.AreEqual(fraction - integer, answer);
        }
        [Test]
        public void Test_FractionMultiplyInteger()
        {
            var fraction = new Fraction(1, 4);
            var integer = 2;
            var answer = new Fraction(1, 2);
            Assert.AreEqual(fraction * integer, answer);
        }
        [Test]
        public void Test_FractionDivideInteger()
        {
            var fraction = new Fraction(1, 4);
            var integer = 2;
            var answer = new Fraction(1, 8);
            Assert.AreEqual(fraction / integer, answer);
        }
    }
}
