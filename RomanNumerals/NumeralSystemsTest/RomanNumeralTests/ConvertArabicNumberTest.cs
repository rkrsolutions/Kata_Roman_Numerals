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
            Assert.IsTrue("i".StringsAreEqual(RomanNumeral.ConvertArabicNumber("1")));
            Assert.IsTrue("ii".StringsAreEqual(RomanNumeral.ConvertArabicNumber("2")));
            Assert.IsTrue("iii".StringsAreEqual(RomanNumeral.ConvertArabicNumber("3")));
        }

        [TestMethod]
        public void FourTest()
        {
            Assert.IsTrue("iv".StringsAreEqual(RomanNumeral.ConvertArabicNumber("4")));
        }

        [TestMethod]
        public void FiveTest()
        {
            Assert.IsTrue("v".StringsAreEqual(RomanNumeral.ConvertArabicNumber("5")));
        }

        [TestMethod]
        public void SixToEightTest()
        {
            Assert.IsTrue("vi".StringsAreEqual(RomanNumeral.ConvertArabicNumber("6")));
            Assert.IsTrue("vii".StringsAreEqual(RomanNumeral.ConvertArabicNumber("7")));
            Assert.IsTrue("viii".StringsAreEqual(RomanNumeral.ConvertArabicNumber("8")));
        }

        [TestMethod]
        public void NineTest()
        {
            Assert.IsTrue("ix".StringsAreEqual(RomanNumeral.ConvertArabicNumber("9")));
        }

        [TestMethod]
        public void TenTest()
        {
            Assert.IsTrue("x".StringsAreEqual(RomanNumeral.ConvertArabicNumber("10")));
        }

        [TestMethod]
        public void GreaterThan10LessThan40Test()
        {
            Assert.IsTrue("xi".StringsAreEqual(RomanNumeral.ConvertArabicNumber("11")));
            Assert.IsTrue("xiii".StringsAreEqual(RomanNumeral.ConvertArabicNumber("13")));
            Assert.IsTrue("xiv".StringsAreEqual(RomanNumeral.ConvertArabicNumber("14")));
            Assert.IsTrue("xv".StringsAreEqual(RomanNumeral.ConvertArabicNumber("15")));
            Assert.IsTrue("xvi".StringsAreEqual(RomanNumeral.ConvertArabicNumber("16")));
            Assert.IsTrue("xix".StringsAreEqual(RomanNumeral.ConvertArabicNumber("19")));
            Assert.IsTrue("xx".StringsAreEqual(RomanNumeral.ConvertArabicNumber("20")));
            Assert.IsTrue("xxi".StringsAreEqual(RomanNumeral.ConvertArabicNumber("21")));
            Assert.IsTrue("xxxviii".StringsAreEqual(RomanNumeral.ConvertArabicNumber("38")));
            Assert.IsTrue("xxxix".StringsAreEqual(RomanNumeral.ConvertArabicNumber("39")));
        }

        [TestMethod]
        public void OneAndTwoLessThenNextNumeralTest()
        {
            Assert.IsTrue("xl".StringsAreEqual(RomanNumeral.ConvertArabicNumber("40")));
            Assert.IsTrue("xliii".StringsAreEqual(RomanNumeral.ConvertArabicNumber("43")));
            Assert.IsTrue("xliv".StringsAreEqual(RomanNumeral.ConvertArabicNumber("44")));
            Assert.IsTrue("xlviii".StringsAreEqual(RomanNumeral.ConvertArabicNumber("48")));
            Assert.IsTrue("xlix".StringsAreEqual(RomanNumeral.ConvertArabicNumber("49")));
            Assert.IsTrue("xc".StringsAreEqual(RomanNumeral.ConvertArabicNumber("90")));
            Assert.IsTrue("xcviii".StringsAreEqual(RomanNumeral.ConvertArabicNumber("98")));
            Assert.IsTrue("xcix".StringsAreEqual(RomanNumeral.ConvertArabicNumber("99")));
            Assert.IsTrue("cd".StringsAreEqual(RomanNumeral.ConvertArabicNumber("400")));
            Assert.IsTrue("cdxcviii".StringsAreEqual(RomanNumeral.ConvertArabicNumber("498")));
            Assert.IsTrue("cdxcix".StringsAreEqual(RomanNumeral.ConvertArabicNumber("499")));
            Assert.IsTrue("cm".StringsAreEqual(RomanNumeral.ConvertArabicNumber("900")));
            Assert.IsTrue("cmxcviii".StringsAreEqual(RomanNumeral.ConvertArabicNumber("998")));
            Assert.IsTrue("cmxcix".StringsAreEqual(RomanNumeral.ConvertArabicNumber("999")));
            Assert.IsTrue("mcdxcviii".StringsAreEqual(RomanNumeral.ConvertArabicNumber("1498")));
            Assert.IsTrue("mcdxcix".StringsAreEqual(RomanNumeral.ConvertArabicNumber("1499")));
            Assert.IsTrue("mmcmxcviii".StringsAreEqual(RomanNumeral.ConvertArabicNumber("2998")));
            Assert.IsTrue("mmcmxcix".StringsAreEqual(RomanNumeral.ConvertArabicNumber("2999")));
        }

        [TestMethod]
        public void ThreeThousandNineHundredNinetyNineTest()
        {
            Assert.IsTrue("mmmcmxcix".StringsAreEqual(RomanNumeral.ConvertArabicNumber("3999")));
        }
    }
}