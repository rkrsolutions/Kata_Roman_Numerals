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
        public void NotNullTest()
        {
            Assert.IsNotNull(ArabicNumeral.ConvertRomanNumeral("m"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidRomanNumeralParameterTest()
        {
            ArabicNumeral.ConvertRomanNumeral(null);
        }

        [TestMethod]
        public void OneTest()
        {
            Assert.IsTrue("1".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumeral("i")));
        }

        [TestMethod]
        public void FiveTest()
        {
            Assert.IsTrue("5".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumeral("v")));
        }

        [TestMethod]
        public void TenTest()
        {
            Assert.IsTrue("10".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumeral("x")));
        }

        [TestMethod]
        public void FiftyTest()
        {
            Assert.IsTrue("50".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumeral("l")));
        }

        #endregion
    }
}