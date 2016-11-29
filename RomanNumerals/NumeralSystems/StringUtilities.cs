﻿#region Using Directives

using System;

#endregion

namespace NumeralSystems
{
    public static class StringUtilities
    {
        #region Methods

        public static bool IgnoreCaseEquals(this string expected, string actual)
        {
            return String.Compare(expected, actual, StringComparison.OrdinalIgnoreCase) == 0;
        }

        #endregion
    }
}