#region Using Directives

using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NumeralSystems;

#endregion

namespace NumeralSystemsTest.ArabicNumeralTests
{
    [TestClass]
    public class ConvertRomanNumeralTest
    {
        #region Methods

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidRomanNumeralParameterTest()
        {
            ArabicNumeral.ConvertRomanNumeral(null);
        }

        [TestMethod]
        public void OneTest()
        {
            Assert.IsTrue("1".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumeral("i").Numeral));
        }

        [TestMethod]
        public void FiveTest()
        {
            Assert.IsTrue("5".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumeral("v").Numeral));
        }

        [TestMethod]
        public void TenTest()
        {
            Assert.IsTrue("10".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumeral("x").Numeral));
        }

        [TestMethod]
        public void FiftyTest()
        {
            Assert.IsTrue("50".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumeral("l").Numeral));
        }

        [TestMethod]
        public void OneHundredTest()
        {
            Assert.IsTrue("100".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumeral("c").Numeral));
        }

        [TestMethod]
        public void FiveHundredTest()
        {
            Assert.IsTrue("500".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumeral("d").Numeral));
        }

        [TestMethod]
        public void OneThousandTest()
        {
            Assert.IsTrue("1000".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumeral("m").Numeral));
        }

        #endregion
    }
}