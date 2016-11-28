#region Using Directives

using System;
using System.Collections.Generic;
using System.Threading;

#endregion

namespace RomanNumerals
{
    public class RomanNumeral
    {
        #region Fields

        private RomanNumeral previousNumeral = null;

        public static IDictionary<int, RomanNumeral> ROMAN_NUMERALS_MAP = new Dictionary<int, RomanNumeral>()
        {
            {0, new RomanNumeral(0, "i", String.Empty)},
            {1, new RomanNumeral(1, "x", "v")},
            {2, new RomanNumeral(2, "c", "l")},
            {3, new RomanNumeral(3, "m", "d")},
        };

        #endregion

        #region Properties

        public int PowerOfTen { get; }
        public string Numeral { get; }
        public string HalfNumeral { get; }

        public RomanNumeral PreviousNumeral
        {
            get
            {
                if ((previousNumeral == null) && (PowerOfTen > 0))
                {
                    previousNumeral = Retrieve(PowerOfTen - 1);
                }

                return previousNumeral;
            }
        }

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
            if (powerOfTen < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(powerOfTen), "Powers of ten must be greater than or equal to zero.");
            }

            return ROMAN_NUMERALS_MAP.ContainsKey(powerOfTen) ? ROMAN_NUMERALS_MAP[powerOfTen] : null;
        }

        #endregion
    }
}