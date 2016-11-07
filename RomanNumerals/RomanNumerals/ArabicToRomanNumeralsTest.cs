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

        #endregion
    }
}