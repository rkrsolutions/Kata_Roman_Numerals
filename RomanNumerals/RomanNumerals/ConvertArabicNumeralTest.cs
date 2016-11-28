using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class ConvertArabicNumeralTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LessThanOneTest()
        {
            RomanNumeral.ConvertArabicNumeral(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GreaterThanTenTest()
        {
            RomanNumeral.ConvertArabicNumeral(11);
        }

        [TestMethod]
        public void NotNullTest()
        {
            Assert.IsNotNull(RomanNumeral.ConvertArabicNumeral(1));
        }
    }
}
