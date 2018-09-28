using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralConverter
{
    public class ConvertNumbers
    {
        public static string romanNumeral { get; set; }

        public static string NumberToRoman(int number)
        {
            if (number == 1)
            {
                romanNumeral = "I";
            }
            if (number == 4)
            {
                romanNumeral = "IV";
            }
            if (number == 5)
            {
                romanNumeral = "V";
            }
            if (number == 9)
            {
                romanNumeral = "IX";
            }
            return romanNumeral;
        }
    }
}
