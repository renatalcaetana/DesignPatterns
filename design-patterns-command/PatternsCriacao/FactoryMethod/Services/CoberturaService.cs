using DesignPatters.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatters.PatternsCriacao.FactoryMethod.Services
{
    public class CoberturaService : IService
    {
        public CoberturaService()
        {
            Console.WriteLine("Produto cobertura criado com sucesso");
        }
        public void ExecutaCobrancaServico()
        {
            throw new NotImplementedException();
        }
    }
}
