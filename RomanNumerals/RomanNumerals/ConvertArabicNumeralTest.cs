using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class ConvertArabicNumeralTest
    {
        [TestMethod]
        public void NotNullTest()
        {
            Assert.IsNotNull(RomanNumeral.ConvertArabicNumeral(1));
        }
    }
}
