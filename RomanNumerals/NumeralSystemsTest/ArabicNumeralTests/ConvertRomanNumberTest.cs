﻿#region Using Directives

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

        [TestMethod]
        public void InvalidRomanNumberFormatTest()
        {
            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("il")));
            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("ic")));
            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("id")));
            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("im")));

            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("vx")));
            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("vl")));
            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("vc")));
            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("vd")));
            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("vm")));

            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("xd")));
            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("xm")));

            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("lc")));
            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("ld")));
            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("lm")));

            Assert.IsTrue(String.Empty.IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("dm")));
        }

        [TestMethod]
        public void CompoundNumeralTest()
        {
            Assert.IsTrue("3".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("iii")));
            Assert.IsTrue("6".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("vi")));
            Assert.IsTrue("7".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("vii")));
            Assert.IsTrue("11".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("xi")));
            Assert.IsTrue("18".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("xviii")));
            Assert.IsTrue("39".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("xxxix")));
            Assert.IsTrue("40".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("xl")));
            Assert.IsTrue("43".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("xliii")));
            Assert.IsTrue("44".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("xliv")));
            Assert.IsTrue("48".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("xlviii")));
            Assert.IsTrue("98".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("xcviii")));
            Assert.IsTrue("99".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("xcix")));
            Assert.IsTrue("498".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("cdxcviii")));
            Assert.IsTrue("988".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("cmlxxxviii")));
            Assert.IsTrue("2998".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("mmcmxcviii")));
            Assert.IsTrue("2999".IgnoreCaseEquals(ArabicNumeral.ConvertRomanNumber("mmcmxcix")));
        }

        #endregion
    }
}