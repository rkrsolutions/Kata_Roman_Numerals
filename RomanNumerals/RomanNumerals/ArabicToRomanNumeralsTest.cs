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
            Assert.IsTrue(String.Compare(RomanNumeralConverter.ArabicToRomanNumerals(1), "i", StringComparison.OrdinalIgnoreCase) == 0);
        }

        [TestMethod]
        public void TwoAndThreeTest()
        {
            Assert.IsTrue(String.Compare(RomanNumeralConverter.ArabicToRomanNumerals(2), "ii", StringComparison.OrdinalIgnoreCase) == 0);
            Assert.IsTrue(String.Compare(RomanNumeralConverter.ArabicToRomanNumerals(3), "iii", StringComparison.OrdinalIgnoreCase) == 0);
        }
    }
}
