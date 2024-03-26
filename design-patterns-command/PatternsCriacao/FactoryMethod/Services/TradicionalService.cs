using DesignPatters.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatters.PatternsCriacao.FactoryMethod.Services
{
    public class TradicionalService : IService
    {
        public TradicionalService()
        {
            Console.WriteLine("Produto tradicional criado com sucesso");
        }
        public void ExecutaCobrancaServico()
        {
            throw new NotImplementedException();
        }
    }
}
