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
            return romanNumeral;
        }
    }
}
