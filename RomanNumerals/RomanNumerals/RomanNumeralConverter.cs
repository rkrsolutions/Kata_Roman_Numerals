#region Using Directives

using System;
using System.Collections.Generic;

#endregion

namespace RomanNumerals
{
    public class RomanNumeral
    {
        public int PowerOfTen { get; private set; }
        public string Numeral { get; private set; }
        public string HalfNumeral { get; private set; }

        public RomanNumeral(int powerOfTen, string numeral, string halfNumeral)
        {
            PowerOfTen = powerOfTen;
            Numeral = numeral;
            HalfNumeral = halfNumeral;
        }
    }

    public class RomanNumeralConverter
    {
        private static readonly RomanNumeral ONE_NUMERAL= new RomanNumeral(0, "i", String.Empty);
        private static readonly RomanNumeral TEN_NUMERAL = new RomanNumeral(1, "x", "v");
        private static readonly RomanNumeral HUNDRED_NUMERAL = new RomanNumeral(2, "c", "l");
        private static readonly RomanNumeral THOUSAND_NUMERAL = new RomanNumeral(3, "m", "d");

        public static IDictionary<int, RomanNumeral> ROMAN_NUMERALS =  new Dictionary<int, RomanNumeral>()
        {
            { ONE_NUMERAL.PowerOfTen, ONE_NUMERAL },
            { TEN_NUMERAL.PowerOfTen, TEN_NUMERAL },
            { HUNDRED_NUMERAL.PowerOfTen, HUNDRED_NUMERAL },
            { THOUSAND_NUMERAL.PowerOfTen, THOUSAND_NUMERAL },
        };
            
        public static string ArabicToRomanNumerals(int arabicNumber)
        {
            string romanNumerals = String.Empty;

            RomanNumeral tenNumeral = ROMAN_NUMERALS[1];
            RomanNumeral oneNumeral = ROMAN_NUMERALS[0];

            int romanNumeralEquivalent  = Convert.ToInt32(Math.Pow(10, tenNumeral.PowerOfTen));
            int previousEquivalent = Convert.ToInt32(Math.Pow(10, oneNumeral.PowerOfTen));

            int halfEquivalent = romanNumeralEquivalent / 2;
            int numeralCount = arabicNumber / romanNumeralEquivalent;

            for (int i = 1; i <= numeralCount; i++)
            {
                romanNumerals += tenNumeral.Numeral;
            }

            int arabicRemainder = arabicNumber % romanNumeralEquivalent;

            if (arabicRemainder > 0)
            {
                if (arabicRemainder == (romanNumeralEquivalent - previousEquivalent))
                {
                    romanNumerals += oneNumeral.Numeral + tenNumeral.Numeral;
                }
                else
                {
                    if (arabicRemainder >= halfEquivalent)
                    {
                        romanNumerals += tenNumeral.HalfNumeral;

                        arabicRemainder -= halfEquivalent;
                    }
                    else if (arabicRemainder >= (halfEquivalent - previousEquivalent))
                    {
                        romanNumerals += oneNumeral.Numeral + tenNumeral.HalfNumeral;

                        arabicRemainder -= halfEquivalent - previousEquivalent;
                    }
                    
                    if (arabicRemainder > 0)
                    {
                        for (int i = 1; i <= arabicRemainder; i++)
                        {
                            romanNumerals += oneNumeral.Numeral;
                        }
                    }
                }
            }

            return romanNumerals;
        }

        public static string ConvertArabicNumeral(string currentRomanNumeral, string halfRomanNumeral, string previousRomanNumeral, int arabicNumeral)
        {
            return null;
        }
    }
}