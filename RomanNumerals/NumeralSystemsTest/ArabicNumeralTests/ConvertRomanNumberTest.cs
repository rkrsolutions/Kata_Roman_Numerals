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
        #region Methods

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

        [TestMethod]
        public void SingleNumeralToArabicNumberTest()
        {
            Assert.IsTrue("1".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("i")));
            Assert.IsTrue("5".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("v")));
            Assert.IsTrue("10".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("x")));
            Assert.IsTrue("50".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("l")));
            Assert.IsTrue("100".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("c")));
            Assert.IsTrue("500".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("d")));
            Assert.IsTrue("1000".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("m")));
        }

        [TestMethod]
        public void OneBeforeNumeralToArabicNumberTest()
        {
            Assert.IsTrue("4".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("iv")));
            Assert.IsTrue("9".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("ix")));
            Assert.IsTrue("40".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("xl")));
            Assert.IsTrue("90".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("xc")));
            Assert.IsTrue("400".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("cd")));
            Assert.IsTrue("900".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("cm")));
        }

        #endregion

    }
}