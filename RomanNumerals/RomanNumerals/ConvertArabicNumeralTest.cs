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

            string oneResult = romanNumeral.ConvertArabicNumeral(1);
            Assert.IsFalse(String.IsNullOrEmpty(oneResult));
            Assert.AreEqual(1, oneResult.Length);

            string twoResult = romanNumeral.ConvertArabicNumeral(2);
            Assert.IsFalse(String.IsNullOrEmpty(twoResult));
            Assert.AreEqual(2, twoResult.Length);
            Assert.IsTrue(twoResult.Contains(oneResult));
            Assert.IsTrue(AllTheSameCharacters(twoResult));

            string threeResult = romanNumeral.ConvertArabicNumeral(2);
            Assert.IsFalse(String.IsNullOrEmpty(threeResult));
            Assert.AreEqual(2, threeResult.Length);
            Assert.IsTrue(twoResult.Contains(oneResult));
            Assert.IsTrue(AllTheSameCharacters(threeResult));
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
    }
}
