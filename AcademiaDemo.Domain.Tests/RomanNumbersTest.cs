namespace AcademiaDemo.Domain.Tests
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using Bogus;

    using Xunit;

    [ExcludeFromCodeCoverage]
    public class RomanNumbersTest
    {
        private readonly Faker faker;

        public RomanNumbersTest()
        {
            this.faker = new Faker();
        }

        [Fact]
        public void Convert_IntToRoman_Fourteen()
        {
            RomanNumbers romanNumbers = new RomanNumbers();
            int number = 14;

            string result = romanNumbers.Convert(number);

            Assert.Equal("XIV", result);
        }

        [Fact]
        public void Convert_IntToRoman_BiggerThanZero_ThrowsException()
        {
            RomanNumbers romanNumbers = new RomanNumbers();
            int number = -2;

            Assert.Throws<Exception>(() => romanNumbers.Convert(number));
        }

        [Fact]
        public void Convert_IntToRoman_SmallerThan3999_ThrowsException()
        {
            RomanNumbers romanNumbers = new RomanNumbers();
            int number = 4001;

            Assert.Throws<Exception>(() => romanNumbers.Convert(number));
        }
    }
}
