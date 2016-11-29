﻿#region Using Directives

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
            string arabicNumber = String.Empty;
            return arabicNumber;
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