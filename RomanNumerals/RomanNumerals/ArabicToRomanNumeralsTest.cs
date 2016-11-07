using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class ArabicToRomanNumeralsTest
    {
        [TestMethod]
        public void NotNullTest()
        {
            Assert.IsNotNull(RomanNumeralConverter.ArabicToRomanNumerals(1));
        }

        [TestMethod]
        public void OneTest()
        {
            Assert.IsTrue(String.Compare(RomanNumeralConverter.ArabicToRomanNumerals(1), "I", StringComparison.OrdinalIgnoreCase) == 0);
        }
    }
}
