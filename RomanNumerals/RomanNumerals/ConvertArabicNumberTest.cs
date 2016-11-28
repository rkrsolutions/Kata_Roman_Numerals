#region Using Directives

using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}