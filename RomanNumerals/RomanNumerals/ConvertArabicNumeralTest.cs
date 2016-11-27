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
            Assert.IsNotNull(RomanNumeralConverter.ConvertArabicNumeral(String.Empty, String.Empty, String.Empty, 1));
        }
    }
}
