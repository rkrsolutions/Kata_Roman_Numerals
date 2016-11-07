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

        public static bool StringsAreEqual(string expected, string actual)
        {
            return String.Compare(expected, actual, StringComparison.OrdinalIgnoreCase) == 0;
        }

        #endregion

        #region Test Methods

        [TestMethod]
        public void NotNullTest()
        {
            Assert.IsNotNull(RomanNumeralConverter.ArabicToRomanNumerals(1));
        }

        [TestMethod]
        public void LessThanOneTest()
        {
            Assert.AreEqual(String.Empty, RomanNumeralConverter.ArabicToRomanNumerals(0));
        }

        [TestMethod]
        public void OneToThreeTest()
        {
            Assert.IsTrue(StringsAreEqual("i", RomanNumeralConverter.ArabicToRomanNumerals(1)));
            Assert.IsTrue(StringsAreEqual("ii", RomanNumeralConverter.ArabicToRomanNumerals(2)));
            Assert.IsTrue(StringsAreEqual("iii", RomanNumeralConverter.ArabicToRomanNumerals(3)));
        }

        [TestMethod]
        public void FourTest()
        {
            Assert.IsTrue(StringsAreEqual("iv", RomanNumeralConverter.ArabicToRomanNumerals(4)));
        }

        [TestMethod]
        public void FiveTest()
        {
            Assert.IsTrue(StringsAreEqual("v", RomanNumeralConverter.ArabicToRomanNumerals(5)));
        }

        [TestMethod]
        public void SixToEightTest()
        {
            Assert.IsTrue(StringsAreEqual("vi", RomanNumeralConverter.ArabicToRomanNumerals(6)));
            Assert.IsTrue(StringsAreEqual("vii", RomanNumeralConverter.ArabicToRomanNumerals(7)));
            Assert.IsTrue(StringsAreEqual("viii", RomanNumeralConverter.ArabicToRomanNumerals(8)));
        }

        [TestMethod]
        public void NineTest()
        {
            Assert.IsTrue(StringsAreEqual("ix", RomanNumeralConverter.ArabicToRomanNumerals(9)));
        }

        [TestMethod]
        public void TenTest()
        {
            Assert.IsTrue(StringsAreEqual("x", RomanNumeralConverter.ArabicToRomanNumerals(10)));
        }

        [TestMethod]
        public void GreaterThan10LessThan40Test()
        {
            Assert.IsTrue(StringsAreEqual("xi", RomanNumeralConverter.ArabicToRomanNumerals(11)));
            Assert.IsTrue(StringsAreEqual("xiii", RomanNumeralConverter.ArabicToRomanNumerals(13)));
            Assert.IsTrue(StringsAreEqual("xiv", RomanNumeralConverter.ArabicToRomanNumerals(14)));
            Assert.IsTrue(StringsAreEqual("xv", RomanNumeralConverter.ArabicToRomanNumerals(15)));
            Assert.IsTrue(StringsAreEqual("xvi", RomanNumeralConverter.ArabicToRomanNumerals(15)));
            Assert.IsTrue(StringsAreEqual("xix", RomanNumeralConverter.ArabicToRomanNumerals(19)));
            Assert.IsTrue(StringsAreEqual("xx", RomanNumeralConverter.ArabicToRomanNumerals(20)));
            Assert.IsTrue(StringsAreEqual("xxi", RomanNumeralConverter.ArabicToRomanNumerals(21)));
            Assert.IsTrue(StringsAreEqual("xxxviii", RomanNumeralConverter.ArabicToRomanNumerals(38)));
            Assert.IsTrue(StringsAreEqual("xxxix", RomanNumeralConverter.ArabicToRomanNumerals(39)));
        }

        #endregion
    }
}