using System;
using Xunit;
using RomanNumeralConverter;

namespace RomanNumeralConverter.Tests
{
    public class NumberConversion
    {
        [Theory]
        [InlineData(1, "I")]

        public void ConvertToRoman(int number, string roman)
        {
            var ConvertNumbers = new ConvertNumbers();
            string result = ConvertNumbers.NumberToRoman(number);
            Assert.Equal(roman, result);
        }
    }
}
