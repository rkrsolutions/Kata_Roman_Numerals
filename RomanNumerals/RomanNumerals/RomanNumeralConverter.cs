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
        private static readonly RomanNumeral ZERO_NUMERAL= new RomanNumeral(0, "i", String.Empty);
        private static readonly RomanNumeral TEN_NUMERAL = new RomanNumeral(1, "x", "v");
        private static readonly RomanNumeral HUNDRED_NUMERAL = new RomanNumeral(2, "c", "l");
        private static readonly RomanNumeral THOUSAND_NUMERAL = new RomanNumeral(3, "m", "d");

        public static IDictionary<int, RomanNumeral> ROMAN_NUMERALS =  new Dictionary<int, RomanNumeral>()
        {
            { ZERO_NUMERAL.PowerOfTen, ZERO_NUMERAL },
            { TEN_NUMERAL.PowerOfTen, TEN_NUMERAL },
            { HUNDRED_NUMERAL.PowerOfTen, HUNDRED_NUMERAL },
            { THOUSAND_NUMERAL.PowerOfTen, THOUSAND_NUMERAL },
        };
            
        public static string ArabicToRomanNumerals(int arabicNumber)
        {
            string romanNumerals = String.Empty;

            int romanNumeralEquivalent  = 10;
            int previousEquivalent = 1;

            int halfEquivalent = romanNumeralEquivalent / 2;
            int numeralCount = arabicNumber / romanNumeralEquivalent;

            for (int i = 1; i <= numeralCount; i++)
            {
                romanNumerals += "x";
            }

            int arabicRemainder = arabicNumber % romanNumeralEquivalent;

            if (arabicRemainder > 0)
            {
                if (arabicRemainder == (romanNumeralEquivalent - previousEquivalent))
                {
                    romanNumerals += "ix";
                }
                else
                {
                    if (arabicRemainder >= halfEquivalent)
                    {
                        romanNumerals += "v";

                        arabicRemainder -= halfEquivalent;
                    }
                    else if (arabicRemainder >= (halfEquivalent - previousEquivalent))
                    {
                        romanNumerals += "iv";

                        arabicRemainder -= halfEquivalent - previousEquivalent;
                    }
                    
                    if (arabicRemainder > 0)
                    {
                        for (int i = 1; i <= arabicRemainder; i++)
                        {
                            romanNumerals += "i";
                        }
                    }
                }
            }

            return romanNumerals;
        }
    }
}