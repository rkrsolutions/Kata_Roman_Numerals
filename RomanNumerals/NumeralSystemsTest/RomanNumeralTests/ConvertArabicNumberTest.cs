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
            Assert.IsTrue("i".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("1")));
            Assert.IsTrue("ii".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("2")));
            Assert.IsTrue("iii".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("3")));
        }

        [TestMethod]
        public void FourTest()
        {
            Assert.IsTrue("iv".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("4")));
        }

        [TestMethod]
        public void FiveTest()
        {
            Assert.IsTrue("v".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("5")));
        }

        [TestMethod]
        public void SixToEightTest()
        {
            Assert.IsTrue("vi".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("6")));
            Assert.IsTrue("vii".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("7")));
            Assert.IsTrue("viii".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("8")));
        }

        [TestMethod]
        public void NineTest()
        {
            Assert.IsTrue("ix".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("9")));
        }

        [TestMethod]
        public void TenTest()
        {
            Assert.IsTrue("x".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("10")));
        }

        [TestMethod]
        public void GreaterThan10LessThan40Test()
        {
            Assert.IsTrue("xi".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("11")));
            Assert.IsTrue("xiii".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("13")));
            Assert.IsTrue("xiv".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("14")));
            Assert.IsTrue("xv".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("15")));
            Assert.IsTrue("xvi".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("16")));
            Assert.IsTrue("xix".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("19")));
            Assert.IsTrue("xx".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("20")));
            Assert.IsTrue("xxi".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("21")));
            Assert.IsTrue("xxxviii".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("38")));
            Assert.IsTrue("xxxix".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("39")));
        }

        [TestMethod]
        public void OneAndTwoLessThenNextNumeralTest()
        {
            Assert.IsTrue("xl".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("40")));
            Assert.IsTrue("xliii".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("43")));
            Assert.IsTrue("xliv".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("44")));
            Assert.IsTrue("xlviii".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("48")));
            Assert.IsTrue("xlix".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("49")));
            Assert.IsTrue("xc".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("90")));
            Assert.IsTrue("xcviii".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("98")));
            Assert.IsTrue("xcix".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("99")));
            Assert.IsTrue("cd".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("400")));
            Assert.IsTrue("cdxcviii".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("498")));
            Assert.IsTrue("cdxcix".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("499")));
            Assert.IsTrue("cm".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("900")));
            Assert.IsTrue("cmxcviii".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("998")));
            Assert.IsTrue("cmxcix".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("999")));
            Assert.IsTrue("mcdxcviii".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("1498")));
            Assert.IsTrue("mcdxcix".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("1499")));
            Assert.IsTrue("mmcmxcviii".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("2998")));
            Assert.IsTrue("mmcmxcix".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("2999")));
        }

        [TestMethod]
        public void ThreeThousandNineHundredNinetyNineTest()
        {
            Assert.IsTrue("mmmcmxcix".IgnoreCaseEquals(RomanNumeral.ConvertArabicNumber("3999")));
        }
    }
}