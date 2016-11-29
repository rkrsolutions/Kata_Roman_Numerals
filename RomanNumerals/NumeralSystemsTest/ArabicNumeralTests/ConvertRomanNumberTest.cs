#region Using Directives

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NumeralSystems;

#endregion

namespace NumeralSystemsTest.ArabicNumeralTests
{
    [TestClass]
    public class ConvertRomanNumberTest
    {
        [TestMethod]
        public void NotNullTest()
        {
            Assert.IsNotNull(ArabicNumeral.ConvertRomanNumber("ab"));
        }
    }
}