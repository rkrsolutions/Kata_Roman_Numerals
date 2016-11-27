using System;

namespace RomanNumerals
{
    public class RomanNumeral
    {
        #region Properties

        public int PowerOfTen { get; private set; }
        public string Numeral { get; private set; }
        public string HalfNumeral { get; private set; }

        #endregion

        #region Construstors

        public RomanNumeral(int powerOfTen, string numeral, string halfNumeral)
        {
            PowerOfTen = powerOfTen;
            Numeral = numeral;
            HalfNumeral = halfNumeral;
        }

        #endregion

        #region Methods

        public static string ConvertArabicNumeral(int arabicNumeral)
        {
            return null;
        }

        #endregion
    }
}