using DesignPatters.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatters.PatternsCriacao.FactoryMethod.Services
{
    public class PremiumService : IService
    {
        public PremiumService()
        {
            Console.WriteLine("Produto premium criado com sucesso");
        }
        public void ExecutaCobrancaServico()
        {
            throw new NotImplementedException();
        }
    }
}
