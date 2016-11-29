using System;
using System.Collections.Generic;

namespace NumeralSystems
{
    public class ArabicNumeral
    {
        #region Fields

        public static IDictionary<string, string> ARABIC_NUMERALS_MAP = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"i", "1"},
            {"v", "5" },
            {"x", "10" },
            {"l", "50" }
        };

        #endregion

        #region Methods

        public static string ConvertRomanNumeral(string romanNumeral, string nextRomanNumeral)
        {
            if (String.IsNullOrEmpty(romanNumeral))
            {
                throw new ArgumentException("The Roman Numeral to convert cannot be null or empty.", nameof(romanNumeral));
            }

            string arabicNumeral = String.Empty;

            if (ARABIC_NUMERALS_MAP.Keys.Contains(romanNumeral))
            {
                arabicNumeral = ARABIC_NUMERALS_MAP[romanNumeral];
            }

            return arabicNumeral;
        }

        #endregion
    }
}