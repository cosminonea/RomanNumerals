﻿namespace RomanNumerals
{
    using System.Text;

    public class RomanNumeralsConverter
    {
        private static readonly int[] Values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static readonly string[] Symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public string Convert(int number)
        {
            var result = new StringBuilder();

            var remaining = number;

            for (int i = 0; i < Values.Length; i++)
            {
                remaining = Convert(remaining, Values[i], Symbols[i], result);                
            }

            return result.ToString();
        }

        private static int Convert(int remaining, int value, string symbol, StringBuilder result)
        {
            while (remaining >= value)
            {
                result.Append(symbol);
                remaining -= value;
            }

            return remaining;
        }
    }
}