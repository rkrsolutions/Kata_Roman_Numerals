using System;
using System.Collections.Generic;

namespace RomanNumerals
{
    public static class RomanNumeralLookUp
    {
        #region Fields

        private static readonly RomanNumeral OneNumeral = new RomanNumeral(0, "i", String.Empty);
        private static readonly RomanNumeral TenNumeral = new RomanNumeral(1, "x", "v");
        private static readonly RomanNumeral HundredNumeral = new RomanNumeral(2, "c", "l");
        private static readonly RomanNumeral ThousandNumeral = new RomanNumeral(3, "m", "d");

        public static IDictionary<int, RomanNumeral> ROMAN_NUMERALS_MAP = new Dictionary<int, RomanNumeral>()
        {
            {OneNumeral.PowerOfTen, OneNumeral},
            {TenNumeral.PowerOfTen, TenNumeral},
            {HundredNumeral.PowerOfTen, HundredNumeral},
            {ThousandNumeral.PowerOfTen, ThousandNumeral},
        };

        #endregion

        public static RomanNumeral RetrieveNumeral(int powerOfTen)
        {
            return ROMAN_NUMERALS_MAP.ContainsKey(powerOfTen) ? ROMAN_NUMERALS_MAP[powerOfTen] : null;
        }
    }
}