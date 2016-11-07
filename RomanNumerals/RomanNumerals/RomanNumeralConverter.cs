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

            for (int i = 1; i <= arabicNumber; i++)
            {
                romanNumerals += "i";
            }

            return romanNumerals;
        }
    }
}