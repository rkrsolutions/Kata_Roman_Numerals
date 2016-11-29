#region Using Directives

using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NumeralSystems;

#endregion

namespace NumeralSystemsTest.RomanNumeralTests
{
    [TestClass]
    public class ConvertArabicNumberTest
    {
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
            Assert.IsTrue(TestUtilities.StringsAreEqual("i", RomanNumeral.ConvertArabicNumber("1")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("ii", RomanNumeral.ConvertArabicNumber("2")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("iii", RomanNumeral.ConvertArabicNumber("3")));
        }

        [TestMethod]
        public void FourTest()
        {
            Assert.IsTrue(TestUtilities.StringsAreEqual("iv", RomanNumeral.ConvertArabicNumber("4")));
        }

        [TestMethod]
        public void FiveTest()
        {
            Assert.IsTrue(TestUtilities.StringsAreEqual("v", RomanNumeral.ConvertArabicNumber("5")));
        }

        [TestMethod]
        public void SixToEightTest()
        {
            Assert.IsTrue(TestUtilities.StringsAreEqual("vi", RomanNumeral.ConvertArabicNumber("6")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("vii", RomanNumeral.ConvertArabicNumber("7")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("viii", RomanNumeral.ConvertArabicNumber("8")));
        }

        [TestMethod]
        public void NineTest()
        {
            Assert.IsTrue(TestUtilities.StringsAreEqual("ix", RomanNumeral.ConvertArabicNumber("9")));
        }

        [TestMethod]
        public void TenTest()
        {
            Assert.IsTrue(TestUtilities.StringsAreEqual("x", RomanNumeral.ConvertArabicNumber("10")));
        }

        [TestMethod]
        public void GreaterThan10LessThan40Test()
        {
            Assert.IsTrue(TestUtilities.StringsAreEqual("xi", RomanNumeral.ConvertArabicNumber("11")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xiii", RomanNumeral.ConvertArabicNumber("13")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xiv", RomanNumeral.ConvertArabicNumber("14")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xv", RomanNumeral.ConvertArabicNumber("15")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xvi", RomanNumeral.ConvertArabicNumber("16")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xix", RomanNumeral.ConvertArabicNumber("19")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xx", RomanNumeral.ConvertArabicNumber("20")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xxi", RomanNumeral.ConvertArabicNumber("21")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xxxviii", RomanNumeral.ConvertArabicNumber("38")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xxxix", RomanNumeral.ConvertArabicNumber("39")));
        }

        [TestMethod]
        public void OneAndTwoLessThenNextNumeralTest()
        {
            Assert.IsTrue(TestUtilities.StringsAreEqual("xl", RomanNumeral.ConvertArabicNumber("40")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xliii", RomanNumeral.ConvertArabicNumber("43")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xliv", RomanNumeral.ConvertArabicNumber("44")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xlviii", RomanNumeral.ConvertArabicNumber("48")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xlix", RomanNumeral.ConvertArabicNumber("49")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xc", RomanNumeral.ConvertArabicNumber("90")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xcviii", RomanNumeral.ConvertArabicNumber("98")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("xcix", RomanNumeral.ConvertArabicNumber("99")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("cd", RomanNumeral.ConvertArabicNumber("400")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("cdxcviii", RomanNumeral.ConvertArabicNumber("498")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("cdxcix", RomanNumeral.ConvertArabicNumber("499")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("cm", RomanNumeral.ConvertArabicNumber("900")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("cmxcviii", RomanNumeral.ConvertArabicNumber("998")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("cmxcix", RomanNumeral.ConvertArabicNumber("999")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("mcdxcviii", RomanNumeral.ConvertArabicNumber("1498")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("mcdxcix", RomanNumeral.ConvertArabicNumber("1499")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("mmcmxcviii", RomanNumeral.ConvertArabicNumber("2998")));
            Assert.IsTrue(TestUtilities.StringsAreEqual("mmcmxcix", RomanNumeral.ConvertArabicNumber("2999")));
        }

        [TestMethod]
        public void ThreeThousandNineHundredNinetyNineTest()
        {
            Assert.IsTrue(TestUtilities.StringsAreEqual("mmmcmxcix", RomanNumeral.ConvertArabicNumber("3999")));
        }
    }
}