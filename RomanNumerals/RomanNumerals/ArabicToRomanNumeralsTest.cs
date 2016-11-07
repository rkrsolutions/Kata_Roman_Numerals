#region Using Directives

using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace RomanNumerals
{
    [TestClass]
    public class ArabicToRomanNumeralsTest
    {
        #region Utilities

        public static bool StringsAreEqual(string argA, string argB)
        {
            return String.Compare(argA, argB, StringComparison.OrdinalIgnoreCase) == 0;
        }

        #endregion

        #region Test Methods

        [TestMethod]
        public void NotNullTest()
        {
            Assert.IsNotNull(RomanNumeralConverter.ArabicToRomanNumerals(1));
        }

        [TestMethod]
        public void OneTest()
        {
            Assert.IsTrue(StringsAreEqual(RomanNumeralConverter.ArabicToRomanNumerals(1), "i"));
        }

        [TestMethod]
        public void TwoAndThreeTest()
        {
            Assert.IsTrue(StringsAreEqual(RomanNumeralConverter.ArabicToRomanNumerals(2), "ii"));
            Assert.IsTrue(StringsAreEqual(RomanNumeralConverter.ArabicToRomanNumerals(3), "iii"));
        }

        [TestMethod]
        public void FourTest()
        {
            Assert.IsTrue(StringsAreEqual(RomanNumeralConverter.ArabicToRomanNumerals(4), "v"));
        }
        #endregion
    }
}