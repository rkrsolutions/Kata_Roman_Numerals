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

            int romanNumeralEquivalent  = 10;
            int numeralCount = arabicNumber / romanNumeralEquivalent;

            for (int i = 1; i <= numeralCount; i++)
            {
                romanNumerals += "x";
            }

            int arabicRemainder = arabicNumber % romanNumeralEquivalent;

            if (arabicRemainder > 0)
            {
                if (arabicRemainder == 9)
                {
                    romanNumerals += "ix";
                }
                else if (arabicRemainder >= 5)
                {
                    romanNumerals += "v";

                    arabicRemainder = arabicNumber % 5;

                    if (arabicRemainder > 0)
                    {
                        for (int i = 1; i <= arabicRemainder; i++)
                        {
                            romanNumerals += "i";
                        }
                    }

                }
                else if (arabicRemainder == 4)
                {
                    romanNumerals += "iv";
                }
                else
                {
                    for (int i = 1; i <= arabicRemainder; i++)
                    {
                        romanNumerals += "i";
                    }
                }
            }

            return romanNumerals;
        }
    }
}