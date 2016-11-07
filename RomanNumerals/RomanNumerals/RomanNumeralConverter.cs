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

            if (arabicNumber == 10)
            {
                romanNumerals = "x";
            }
            else if (arabicNumber == 9)
            {
                romanNumerals = "ix";
            }
            else if (arabicNumber >= 5)
            {
                romanNumerals = "v";

                int arabicRemainder = arabicNumber % 5;

                if (arabicRemainder > 0)
                {
                    for (int i = 1; i <= arabicRemainder; i++)
                    {
                        romanNumerals += "i";
                    }
                }

            }
            else if (arabicNumber == 4)
            {
                romanNumerals = "iv";
            }
            else
            {
                for (int i = 1; i <= arabicNumber; i++)
                {
                    romanNumerals += "i";
                }
            }

            return romanNumerals;
        }
    }
}