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
        [TestCase(10, Result = "X")]
        [TestCase(11, Result = "XI")]
        [TestCase(14, Result = "XIV")]
        [TestCase(15, Result = "XV")]
        [TestCase(16, Result = "XVI")]
        [TestCase(19, Result = "XIX")]
        [TestCase(24, Result = "XXIV")]
        [TestCase(34, Result = "XXXIV")]
        [TestCase(39, Result = "XXXIX")]
        [TestCase(40, Result = "XL")]
        [TestCase(50, Result = "L")]
        [TestCase(60, Result = "LX")]
        [TestCase(70, Result = "LXX")]
        [TestCase(80, Result = "LXXX")]
        [TestCase(90, Result = "XC")]
        [TestCase(100, Result = "C")]
        [TestCase(400, Result = "CD")]
        [TestCase(500, Result = "D")]
        [TestCase(900, Result = "CM")]
        [TestCase(1000, Result = "M")]
        [TestCase(1999, Result = "MCMXCIX")]
        public string ShouldConvertNumbers(int number)
        {
            var converter = new RomanNumeralsConverter();

            return converter.Convert(number);
        }
    }
}