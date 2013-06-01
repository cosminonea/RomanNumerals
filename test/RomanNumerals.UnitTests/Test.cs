namespace RomanNumerals.UnitTests
{
    using NUnit.Framework;

    public class SomeTest
    {
        [TestCase(1, Result = "I")]
        [TestCase(2, Result = "II")]
        [TestCase(3, Result = "III")]
        [TestCase(4, Result = "IV")]
        [TestCase(5, Result = "V")]
        [TestCase(6, Result = "VI")]
        [TestCase(7, Result = "VII")]
        [TestCase(8, Result = "VIII")]
        [TestCase(9, Result = "IX")]
        public string ShouldConvertOne(int number)
        {
            var converter = new RomanNumeralsConverter();

            return converter.Convert(number);
        }
    }
}