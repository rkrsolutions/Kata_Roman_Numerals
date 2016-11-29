using System;

namespace NumeralSystems
{
    public class ArabicNumeral
    {
        #region Methods

        public static string ConvertRomanNumeral(string romanNumeral, string nextRomanNumeral)
        {
            if (String.IsNullOrEmpty(romanNumeral))
            {
                throw new ArgumentException("The Roman Numeral to convert cannot be null or empty.", nameof(romanNumeral));
            }

            string arabicNumeral = String.Empty;

            if (romanNumeral.IgnoreCaseEquals("i"))
            {
                arabicNumeral = "1";
            }

            return arabicNumeral;
        }

        #endregion
    }
}