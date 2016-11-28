using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class ConvertArabicNumeralTest
    {
        #region Utilities

        public static bool AllTheSameCharacters(string stringToTest)
        {
            bool result = false;

            if (!String.IsNullOrEmpty(stringToTest))
            {
                char firstCharacter = stringToTest[0];

                result = stringToTest.Length == stringToTest.Count(c => c.Equals(firstCharacter));
            }

            return result;
        }

        #endregion

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LessThanOneTest()
        {
            RomanNumeral.Retrieve(1).ConvertArabicNumeral(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GreaterThanTenTest()
        {
            RomanNumeral.Retrieve(1).ConvertArabicNumeral(11);
        }

        [TestMethod]
        public void NotNullTest()
        {
            Assert.IsNotNull(RomanNumeral.Retrieve(1).ConvertArabicNumeral(1));
        }

        [TestMethod]
        public void OneToThreeTest()
        {
            RomanNumeral romanNumeral = RomanNumeral.Retrieve(1);
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

        [TestMethod]
        public void FourTest()
        {
            RomanNumeral romanNumeral = RomanNumeral.Retrieve(1);

            string fourResult = romanNumeral.ConvertArabicNumeral(4);
            Assert.IsFalse(String.IsNullOrEmpty(fourResult));
            Assert.AreEqual(2, fourResult.Length);
            Assert.AreEqual(romanNumeral.PreviousNumeral.Numeral + romanNumeral.HalfNumeral, fourResult);
        }

        [TestMethod]
        public void FiveTest()
        {
            RomanNumeral romanNumeral = RomanNumeral.Retrieve(1);

            string oneResult = romanNumeral.ConvertArabicNumeral(1);
            string fiveResult = romanNumeral.ConvertArabicNumeral(5);
            Assert.IsFalse(String.IsNullOrEmpty(fiveResult));
            Assert.AreEqual(1, fiveResult.Length);
            Assert.AreNotEqual(oneResult, fiveResult);
            Assert.AreEqual(romanNumeral.HalfNumeral, fiveResult);
        }

        [TestMethod]
        public void SixToEightTest()
        {
            RomanNumeral romanNumeral = RomanNumeral.Retrieve(1);
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

        [TestMethod]
        public void NineTest()
        {
            RomanNumeral romanNumeral = RomanNumeral.Retrieve(1);

            string nineResult = romanNumeral.ConvertArabicNumeral(9);
            Assert.IsFalse(String.IsNullOrEmpty(nineResult));
            Assert.AreEqual(2, nineResult.Length);
            Assert.AreEqual(romanNumeral.PreviousNumeral.Numeral + romanNumeral.Numeral, nineResult);
        }
    }
}
