namespace AcademiaDemo.Services.Tests
{
    using System.Diagnostics.CodeAnalysis;

    using AcademiaDemo.Data;
    using AcademiaDemo.Domain;

    using Bogus;

    using Moq;

    using Xunit;

    [ExcludeFromCodeCoverage]
    public class CarroServiceTest
    {
        [Fact]
        public void Adicionar_NovoCarro_Sucesso()
        {
            // Arrange
            var carro = new Carro(new Faker().Vehicle.Model());
            var carroRepositoryMock = new Mock<ICarroRepository>();

            var carroService = new CarroService(carroRepositoryMock.Object);

            // Act
            carroService.Adicionar(carro);

            // Assert
            carroRepositoryMock.Verify(v => v.Adicionar(It.IsAny<Carro>()), Times.Once);
        }
    }
}
