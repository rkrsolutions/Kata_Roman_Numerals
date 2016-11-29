#region Using Directives

using System;

#endregion

namespace NumeralSystemsTest
{
    public static class TestUtilities
    {
        #region Methods

        public static bool StringsAreEqual(this string expected, string actual)
        {
            return String.Compare(expected, actual, StringComparison.OrdinalIgnoreCase) == 0;
        }

        #endregion
    }
}