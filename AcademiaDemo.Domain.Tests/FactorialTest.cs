namespace AcademiaDemo.Domain.Tests
{

    using System;
    using System.Diagnostics.CodeAnalysis;

    using Bogus;

    using Xunit;

    [ExcludeFromCodeCoverage]
    public class FactorialTest
    {
        private readonly Faker faker;

        public FactorialTest()
        {
            this.faker = new Faker();
        }

        [Fact]
        public void Calculate_Factorial_NotZero()
        {
            Factorial factorial = new Factorial();
            int number = faker.Random.Int(1, 30);

            int actual = factorial.CalculateFactorial(number);

            Assert.NotEqual(0, actual);
        }

        [Fact]
        public void Calculate_Factorial_FiveIs120()
        {
            // Arrange
            Factorial factorial = new Factorial();
            int number = 5;
            int expected = 120;

            // Act 
            int actual = factorial.CalculateFactorial(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculate_Factorial_NegativeNumber_ThrowsException()
        {
            Factorial factorial = new Factorial();
            int number = faker.Random.Int(-20, -1);

            Assert.Throws<Exception>(() => factorial.CalculateFactorial(number));
        }

        [Fact]
        public void Calculate_Factorial_NumberBiggerThan30_ThrowsException()
        {
            Factorial factorial = new Factorial();
            int number = 31;

            Assert.Throws<Exception>(() => factorial.CalculateFactorial(number));
        }
    }
}
