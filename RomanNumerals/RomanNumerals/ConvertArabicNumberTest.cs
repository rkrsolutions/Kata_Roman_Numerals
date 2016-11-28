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
    }
}