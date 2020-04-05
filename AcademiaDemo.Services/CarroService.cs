namespace AcademiaDemo.Services
{
    using AcademiaDemo.Data;
    using AcademiaDemo.Domain;

    public class CarroService
    {
        private readonly ICarroRepository carroRepository;

        public CarroService(ICarroRepository carroRepository)
        {
            this.carroRepository = carroRepository;
        }

        public void Adicionar(Carro carro)
        {
            this.carroRepository.Adicionar(carro);
        }
    }
}
