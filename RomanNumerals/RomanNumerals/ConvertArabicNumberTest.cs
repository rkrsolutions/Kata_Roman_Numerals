﻿#region Using Directives

using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NumeralSystems;

#endregion

namespace RomanNumerals
{
    [TestClass]
    public class ConvertArabicNumberTest
    {
        #region Utilities

        public static bool StringsAreEqual(string expected, string actual)
        {
            return String.Compare(expected, actual, StringComparison.OrdinalIgnoreCase) == 0;
        }

        #endregion

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void InvalidArabicNumberStringTest()
        {
            RomanNumeral.ConvertArabicNumber("abc");
        }

        [TestMethod]
        public void NotNullResultStringTest()
        { 
            Assert.IsNotNull(RomanNumeral.ConvertArabicNumber("1"));
        }

        [TestMethod]
        public void NotNullResultIntTest()
        {
            Assert.IsNotNull(RomanNumeral.ConvertArabicNumber(1));
        }

        [TestMethod]
        public void OutOfNumericRangeTest()
        {
            string zeroResult = RomanNumeral.ConvertArabicNumber(0);
            Assert.AreEqual(String.Empty, zeroResult);
            string fourThousandResult = RomanNumeral.ConvertArabicNumber(4000);
            Assert.AreEqual(String.Empty, fourThousandResult);
        }

        [TestMethod]
        public void OneToThreeTest()
        {
            Assert.IsTrue(StringsAreEqual("i", RomanNumeral.ConvertArabicNumber("1")));
            Assert.IsTrue(StringsAreEqual("ii", RomanNumeral.ConvertArabicNumber("2")));
            Assert.IsTrue(StringsAreEqual("iii", RomanNumeral.ConvertArabicNumber("3")));
        }

        [TestMethod]
        public void FourTest()
        {
            Assert.IsTrue(StringsAreEqual("iv", RomanNumeral.ConvertArabicNumber("4")));
        }

        [TestMethod]
        public void FiveTest()
        {
            Assert.IsTrue(StringsAreEqual("v", RomanNumeral.ConvertArabicNumber("5")));
        }

        [TestMethod]
        public void SixToEightTest()
        {
            Assert.IsTrue(StringsAreEqual("vi", RomanNumeral.ConvertArabicNumber("6")));
            Assert.IsTrue(StringsAreEqual("vii", RomanNumeral.ConvertArabicNumber("7")));
            Assert.IsTrue(StringsAreEqual("viii", RomanNumeral.ConvertArabicNumber("8")));
        }

        [TestMethod]
        public void NineTest()
        {
            Assert.IsTrue(StringsAreEqual("ix", RomanNumeral.ConvertArabicNumber("9")));
        }

        [TestMethod]
        public void TenTest()
        {
            Assert.IsTrue(StringsAreEqual("x", RomanNumeral.ConvertArabicNumber("10")));
        }

        [TestMethod]
        public void GreaterThan10LessThan40Test()
        {
            Assert.IsTrue(StringsAreEqual("xi", RomanNumeral.ConvertArabicNumber("11")));
            Assert.IsTrue(StringsAreEqual("xiii", RomanNumeral.ConvertArabicNumber("13")));
            Assert.IsTrue(StringsAreEqual("xiv", RomanNumeral.ConvertArabicNumber("14")));
            Assert.IsTrue(StringsAreEqual("xv", RomanNumeral.ConvertArabicNumber("15")));
            Assert.IsTrue(StringsAreEqual("xvi", RomanNumeral.ConvertArabicNumber("16")));
            Assert.IsTrue(StringsAreEqual("xix", RomanNumeral.ConvertArabicNumber("19")));
            Assert.IsTrue(StringsAreEqual("xx", RomanNumeral.ConvertArabicNumber("20")));
            Assert.IsTrue(StringsAreEqual("xxi", RomanNumeral.ConvertArabicNumber("21")));
            Assert.IsTrue(StringsAreEqual("xxxviii", RomanNumeral.ConvertArabicNumber("38")));
            Assert.IsTrue(StringsAreEqual("xxxix", RomanNumeral.ConvertArabicNumber("39")));
        }

        [TestMethod]
        public void OneAndTwoLessThenNextNumeralTest()
        {
            Assert.IsTrue(StringsAreEqual("xl", RomanNumeral.ConvertArabicNumber("40")));
            Assert.IsTrue(StringsAreEqual("xliii", RomanNumeral.ConvertArabicNumber("43")));
            Assert.IsTrue(StringsAreEqual("xliv", RomanNumeral.ConvertArabicNumber("44")));
            Assert.IsTrue(StringsAreEqual("xlviii", RomanNumeral.ConvertArabicNumber("48")));
            Assert.IsTrue(StringsAreEqual("xlix", RomanNumeral.ConvertArabicNumber("49")));
            Assert.IsTrue(StringsAreEqual("xc", RomanNumeral.ConvertArabicNumber("90")));
            Assert.IsTrue(StringsAreEqual("xcviii", RomanNumeral.ConvertArabicNumber("98")));
            Assert.IsTrue(StringsAreEqual("xcix", RomanNumeral.ConvertArabicNumber("99")));
            Assert.IsTrue(StringsAreEqual("cd", RomanNumeral.ConvertArabicNumber("400")));
            Assert.IsTrue(StringsAreEqual("cdxcviii", RomanNumeral.ConvertArabicNumber("498")));
            Assert.IsTrue(StringsAreEqual("cdxcix", RomanNumeral.ConvertArabicNumber("499")));
            Assert.IsTrue(StringsAreEqual("cm", RomanNumeral.ConvertArabicNumber("900")));
            Assert.IsTrue(StringsAreEqual("cmxcviii", RomanNumeral.ConvertArabicNumber("998")));
            Assert.IsTrue(StringsAreEqual("cmxcix", RomanNumeral.ConvertArabicNumber("999")));
            Assert.IsTrue(StringsAreEqual("mcdxcviii", RomanNumeral.ConvertArabicNumber("1498")));
            Assert.IsTrue(StringsAreEqual("mcdxcix", RomanNumeral.ConvertArabicNumber("1499")));
            Assert.IsTrue(StringsAreEqual("mmcmxcviii", RomanNumeral.ConvertArabicNumber("2998")));
            Assert.IsTrue(StringsAreEqual("mmcmxcix", RomanNumeral.ConvertArabicNumber("2999")));
        }

        [TestMethod]
        public void ThreeThousandNineHundredNinetyNineTest()
        {
            Assert.IsTrue(StringsAreEqual("mmmcmxcix", RomanNumeral.ConvertArabicNumber("3999")));
        }
    }
}