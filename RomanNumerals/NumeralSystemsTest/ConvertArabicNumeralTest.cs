#region Using Directives

using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NumeralSystems;

#endregion

namespace NumeralSystemsTest
{
    [TestClass]
    public class ConvertArabicNumeralTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LessThanZeroTest()
        {
            for (int i = 1; i <= 3; i++)
            {
                RomanNumeral romanNumeral = RomanNumeral.Retrieve(i);
                romanNumeral.ConvertArabicNumeral(-1);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GreaterThanNineTest()
        {
            for (int i = 1; i <= 3; i++)
            {
                RomanNumeral romanNumeral = RomanNumeral.Retrieve(i);
                romanNumeral.ConvertArabicNumeral(10);
            }
        }

        [TestMethod]
        public void NotNullTest()
        {
            for (int i = 1; i <= 3; i++)
            {
                RomanNumeral romanNumeral = RomanNumeral.Retrieve(i);
                Assert.IsNotNull(romanNumeral.ConvertArabicNumeral(1));
            }
        }

        [TestMethod]
        public void ZeroTest()
        {
            for (int i = 1; i <= 3; i++)
            {
                RomanNumeral romanNumeral = RomanNumeral.Retrieve(i);
                string zeroResult = romanNumeral.ConvertArabicNumeral(0);
                Assert.AreEqual(String.Empty, zeroResult);
            }
        }

        [TestMethod]
        public void OneToThreeTest()
        {
            for (int i = 1; i <= 3; i++)
            {
                RomanNumeral romanNumeral = RomanNumeral.Retrieve(i);
                string previousNumeral = romanNumeral.PreviousNumeral.Numeral;

                string oneResult = romanNumeral.ConvertArabicNumeral(1);
                Assert.IsFalse(String.IsNullOrEmpty(oneResult));
                Assert.AreEqual(previousNumeral, oneResult);

                string twoResult = romanNumeral.ConvertArabicNumeral(2);
                Assert.IsFalse(String.IsNullOrEmpty(twoResult));
                Assert.AreEqual(previousNumeral + previousNumeral, twoResult);

                string threeResult = romanNumeral.ConvertArabicNumeral(3);
                Assert.IsFalse(String.IsNullOrEmpty(threeResult));
                Assert.AreEqual(previousNumeral + previousNumeral + previousNumeral, threeResult);
            }
        }

        [TestMethod]
        public void FourTest()
        {
            for (int i = 1; i <= 3; i++)
            {
                RomanNumeral romanNumeral = RomanNumeral.Retrieve(i);

                string fourResult = romanNumeral.ConvertArabicNumeral(4);
                Assert.IsFalse(String.IsNullOrEmpty(fourResult));
                Assert.AreEqual(2, fourResult.Length);
                Assert.AreEqual(romanNumeral.PreviousNumeral.Numeral + romanNumeral.HalfNumeral, fourResult);
            }
        }

        [TestMethod]
        public void FiveTest()
        {
            for (int i = 1; i <= 3; i++)
            {
                RomanNumeral romanNumeral = RomanNumeral.Retrieve(i);

                string oneResult = romanNumeral.ConvertArabicNumeral(1);
                string fiveResult = romanNumeral.ConvertArabicNumeral(5);
                Assert.IsFalse(String.IsNullOrEmpty(fiveResult));
                Assert.AreEqual(1, fiveResult.Length);
                Assert.AreNotEqual(oneResult, fiveResult);
                Assert.AreEqual(romanNumeral.HalfNumeral, fiveResult);
            }
        }

        [TestMethod]
        public void SixToEightTest()
        {
            for (int i = 1; i <= 3; i++)
            {
                RomanNumeral romanNumeral = RomanNumeral.Retrieve(i);
                string previousNumeral = romanNumeral.PreviousNumeral.Numeral;

                string sixResult = romanNumeral.ConvertArabicNumeral(6);
                Assert.IsFalse(String.IsNullOrEmpty(sixResult));
                Assert.AreEqual(romanNumeral.HalfNumeral + previousNumeral, sixResult);

                string twoResult = romanNumeral.ConvertArabicNumeral(7);
                Assert.IsFalse(String.IsNullOrEmpty(twoResult));
                Assert.AreEqual(romanNumeral.HalfNumeral + previousNumeral + previousNumeral, twoResult);

                string threeResult = romanNumeral.ConvertArabicNumeral(8);
                Assert.IsFalse(String.IsNullOrEmpty(threeResult));
                Assert.AreEqual(romanNumeral.HalfNumeral + previousNumeral + previousNumeral + previousNumeral, threeResult);
            }
        }

        [TestMethod]
        public void NineTest()
        {
            for (int i = 1; i <= 3; i++)
            {
                RomanNumeral romanNumeral = RomanNumeral.Retrieve(i);

                string nineResult = romanNumeral.ConvertArabicNumeral(9);
                Assert.IsFalse(String.IsNullOrEmpty(nineResult));
                Assert.AreEqual(2, nineResult.Length);
                Assert.AreEqual(romanNumeral.PreviousNumeral.Numeral + romanNumeral.Numeral, nineResult);
            }
        }
    }
}