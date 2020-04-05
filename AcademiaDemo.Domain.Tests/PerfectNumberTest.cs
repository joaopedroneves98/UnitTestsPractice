namespace AcademiaDemo.Domain.Tests

{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using Bogus;

    using Xunit;

    [ExcludeFromCodeCoverage]
    public class PerfectNumberTest
    {
        private readonly Faker faker;

        public PerfectNumberTest()
        {
            this.faker = new Faker();
        }

        [Theory]
        [InlineData(6)]
        [InlineData(28)]
        [InlineData(496)]
        public void Check_PerfectNumber_InlineDataIsPerfect(int number)
        {
            PerfectNumbers perfectNumbers = new PerfectNumbers();

            bool actual = perfectNumbers.IsPerfectNumber(number);

            Assert.True(actual);
        }

        [Fact]
        public void Check_PerfectNumber_NotNegative_ThrowsException()
        {
            PerfectNumbers perfectNumbers = new PerfectNumbers();
            int number = faker.Random.Int(-40, -1);

            Assert.Throws<Exception>(() => perfectNumbers.IsPerfectNumber(number));
        }

        [Fact]
        public void Check_PerfectNumber_NotBiggerThan10000_ThrowsException()
        {
            PerfectNumbers perfectNumbers = new PerfectNumbers();
            int number = faker.Random.Int(10001, int.MaxValue);

            Assert.Throws<Exception>(() => perfectNumbers.IsPerfectNumber(number));
        }
    }
}
