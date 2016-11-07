﻿#region Using Directives

using System;

#endregion

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        public static string ArabicToRomanNumerals(int arabicNumber)
        {
            string romanNumerals = String.Empty;

            if (arabicNumber < 4)
            {
                for (int i = 1; i <= arabicNumber; i++)
                {
                    romanNumerals += "i";
                }
            }
            else if (arabicNumber == 4)
            {
                romanNumerals = "iv";
            }
            else
            {
                romanNumerals = "v";
            }

            return romanNumerals;
        }
    }
}