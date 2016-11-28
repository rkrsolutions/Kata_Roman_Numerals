#region Using Directives

using System;

#endregion

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {          
        public static string ArabicToRomanNumerals(int arabicNumber)
        {
            string romanNumerals = String.Empty;

            RomanNumeral tenNumeral = RomanNumeral.Retrieve(1);
            RomanNumeral oneNumeral = RomanNumeral.Retrieve(0);

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
    }
}