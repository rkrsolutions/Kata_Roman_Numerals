using System;
using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanNumeral
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

        #region Properties

        public int PowerOfTen { get; }
        public string Numeral { get; }
        public string HalfNumeral { get; }

        #endregion

        #region Construstors

        private RomanNumeral(int powerOfTen, string numeral, string halfNumeral)
        {
            PowerOfTen = powerOfTen;
            Numeral = numeral;
            HalfNumeral = halfNumeral;
        }

        #endregion

        #region Methods

        public string ConvertArabicNumeral(int arabicNumeral)
        {
            if ((arabicNumeral < 1) || (arabicNumeral > 10))
            {
                throw new ArgumentOutOfRangeException(nameof(arabicNumeral), "The Arabic numeral to convert must be between 1 and 10 in value.");
            }

            string result = String.Empty;

            return result;
        }

        public static RomanNumeral Retrieve(int powerOfTen)
        {
            return ROMAN_NUMERALS_MAP.ContainsKey(powerOfTen) ? ROMAN_NUMERALS_MAP[powerOfTen] : null;
        }

        #endregion
    }
}