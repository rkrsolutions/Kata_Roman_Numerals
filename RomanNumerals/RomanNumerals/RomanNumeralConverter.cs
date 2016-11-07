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

            if ((arabicNumber % 5) == 0)
            {
                romanNumerals = "v";
            }
            else if ((arabicNumber + 1) % 5 == 0)
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