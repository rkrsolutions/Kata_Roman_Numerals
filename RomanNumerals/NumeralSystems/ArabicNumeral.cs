#region Using Directives

using System;
using System.Collections.Generic;

#endregion

namespace NumeralSystems
{
    public class ArabicNumeral
    {
        #region Fields

        public static IDictionary<string, ArabicNumeral> ARABIC_NUMERALS_MAP = new Dictionary<string, ArabicNumeral>(StringComparer.OrdinalIgnoreCase)
        {
            {"i", new ArabicNumeral(1)},
            {"v", new ArabicNumeral(5)},
            {"x", new ArabicNumeral(10)},
            {"l", new ArabicNumeral(50)},
            {"c", new ArabicNumeral(100)},
            {"d", new ArabicNumeral(500)},
            {"m", new ArabicNumeral(1000)}
        };

        #endregion

        #region Properties

        public int IntegerValue { get; }

        public string Numeral
        {
            get { return IntegerValue.ToString(); }
        }

        #endregion

        #region Constructors

        public ArabicNumeral(int integerValue)
        {
            IntegerValue = integerValue;
        }

        #endregion

        #region Methods

        public static string ConvertRomanNumber(string romanNumber)
        {
            if (String.IsNullOrEmpty(romanNumber))
            {
                throw new ArgumentException("The Roman Numeral to convert cannot be null or empty.", nameof(romanNumber));
            }

            int? arabicNumber = 0;
            
            for (int i = 0; i < romanNumber.Length && arabicNumber.HasValue; i++)
            {
                ArabicNumeral arabicNumeral = ConvertRomanNumeral(romanNumber[i].ToString());

                if (arabicNumeral != null)
                {
                    ArabicNumeral nextArabicNumeral = null;

                    if (i + 1 < romanNumber.Length)
                    {
                        nextArabicNumeral = ConvertRomanNumeral(romanNumber[i + 1].ToString());
                    }

                    if ((nextArabicNumeral != null) && (nextArabicNumeral.IntegerValue > arabicNumeral.IntegerValue))
                    {
                        if (((nextArabicNumeral.IntegerValue != arabicNumeral.IntegerValue * 5) && (nextArabicNumeral.IntegerValue != arabicNumeral.IntegerValue * 10)) || 
                            (arabicNumeral.IntegerValue == 5) || (arabicNumeral.IntegerValue == 50) || (arabicNumeral.IntegerValue == 500))
                        {
                            arabicNumber = null;
                        }
                        else
                        {
                            arabicNumber -= arabicNumeral.IntegerValue;
                        }
                    }
                    else
                    {
                        arabicNumber += arabicNumeral.IntegerValue;
                    }
                }
            }

            return arabicNumber.HasValue ? arabicNumber.ToString() : String.Empty;
        }

        public static ArabicNumeral ConvertRomanNumeral(string romanNumeral)
        {
            if (String.IsNullOrEmpty(romanNumeral))
            {
                throw new ArgumentException("The Roman Numeral to convert cannot be null or empty.", nameof(romanNumeral));
            }

            ArabicNumeral arabicNumeral = null;

            if (ARABIC_NUMERALS_MAP.Keys.Contains(romanNumeral))
            {
                arabicNumeral = ARABIC_NUMERALS_MAP[romanNumeral];
            }

            return arabicNumeral;
        }

        #endregion
    }
}