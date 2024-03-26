using DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteCriacao.Interfaces;
using DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteProduto.Produtos;

namespace DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteCriacao.Factories
{
    public class SegundaQuintaFactory : IFactory
    {
        public SegundaQuintaFactory()
        {
            ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Segunda a Quinta Criada");
            var dieta = new DietaSegundaQuinta();
            var treino = new TreinoSegundaQuinta();

            dieta.ObterAlimentacao();
            treino.ObterTreino();

        }
    }
}
