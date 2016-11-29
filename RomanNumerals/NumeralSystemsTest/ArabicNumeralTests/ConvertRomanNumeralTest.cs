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
            Assert.IsNotNull(ArabicNumeral.ConvertRomanNumeral(null, null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidRomanNumeralParameter()
        {
            ArabicNumeral.ConvertRomanNumeral(null, null);
        }

        #endregion
    }
}