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
        public void OneToThreeTest()
        {
            Assert.IsTrue(StringsAreEqual(RomanNumeralConverter.ArabicToRomanNumerals(1), "i"));
            Assert.IsTrue(StringsAreEqual(RomanNumeralConverter.ArabicToRomanNumerals(2), "ii"));
            Assert.IsTrue(StringsAreEqual(RomanNumeralConverter.ArabicToRomanNumerals(3), "iii"));
        }

        [TestMethod]
        public void FourTest()
        {
            Assert.IsTrue(StringsAreEqual(RomanNumeralConverter.ArabicToRomanNumerals(4), "iv"));
        }

        [TestMethod]
        public void FiveTest()
        {
            Assert.IsTrue(StringsAreEqual(RomanNumeralConverter.ArabicToRomanNumerals(5), "v"));
        }

        [TestMethod]
        public void SixToEightTest()
        {
            Assert.IsTrue(StringsAreEqual(RomanNumeralConverter.ArabicToRomanNumerals(6), "vi"));
            Assert.IsTrue(StringsAreEqual(RomanNumeralConverter.ArabicToRomanNumerals(7), "vii"));
            Assert.IsTrue(StringsAreEqual(RomanNumeralConverter.ArabicToRomanNumerals(8), "viii"));
        }

        [TestMethod]
        public void NineTest()
        {
            Assert.IsTrue(StringsAreEqual(RomanNumeralConverter.ArabicToRomanNumerals(9), "ix"));
        }

    #endregion
    }
}