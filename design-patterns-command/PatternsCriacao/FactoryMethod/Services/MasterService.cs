using DesignPatters.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatters.PatternsCriacao.FactoryMethod.Services
{
    public class MasterService : IService
    {
        public MasterService()
        {
            Console.WriteLine("Produto master criado com sucesso");
        }
        public void ExecutaCobrancaServico()
        {
            throw new NotImplementedException();
        }
    }
}
