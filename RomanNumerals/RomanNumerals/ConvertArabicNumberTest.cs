#region Using Directives

using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace RomanNumerals
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
    }
}