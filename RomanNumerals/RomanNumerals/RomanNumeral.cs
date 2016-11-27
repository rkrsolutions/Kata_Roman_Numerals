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

        public static string ConvertArabicNumeral(string currentRomanNumeral, string halfRomanNumeral, string previousRomanNumeral, int arabicNumeral)
        {
            return null;
        }
    }
}