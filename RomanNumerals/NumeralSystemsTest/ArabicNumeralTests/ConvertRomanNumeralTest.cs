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
            Assert.IsNotNull(ArabicNumeral.ConvertRomanNumeral("m", null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidRomanNumeralParameterTest()
        {
            ArabicNumeral.ConvertRomanNumeral(null, null);
        }

        [TestMethod]
        public void OneTest()
        {
            Assert.IsTrue("1".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumeral("i", String.Empty)));
        }

        [TestMethod]
        public void FiveTest()
        {
            Assert.IsTrue("5".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumeral("v", String.Empty)));
        }

        [TestMethod]
        public void TenTest()
        {
            Assert.IsTrue("5".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumeral("x", String.Empty)));
        }

        #endregion
    }
}