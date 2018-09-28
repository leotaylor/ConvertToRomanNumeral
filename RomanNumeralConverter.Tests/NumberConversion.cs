using System;
using Xunit;
using RomanNumeralConverter;

namespace RomanNumeralConverter.Tests
{
    public class NumberConversion
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(9, "IX")]

        public void ConvertToRoman(int number, string roman)
        {
            var ConvertNumbers = new ConvertNumbers();
            string result = ConvertNumbers.NumberToRoman(number);
            Assert.Equal(roman, result);
        }
    }
}
