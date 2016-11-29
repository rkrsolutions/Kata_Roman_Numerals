#region Using Directives

using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NumeralSystems;

#endregion

namespace NumeralSystemsTest.ArabicNumeralTests
{
    [TestClass]
    public class ConvertRomanNumberTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RomanNumberParameterNullTest()
        {
            ArabicNumeral.ConvertRomanNumber(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RomanNumberParameterEmptyTest()
        {
            ArabicNumeral.ConvertRomanNumber(String.Empty);
        }

        [TestMethod]
        public void NotNullTest()
        {
            Assert.IsNotNull(ArabicNumeral.ConvertRomanNumber("ab"));
        }
    }
}