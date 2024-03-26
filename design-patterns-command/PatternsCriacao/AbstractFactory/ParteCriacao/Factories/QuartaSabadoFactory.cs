using DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteCriacao.Interfaces;
using DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteProduto.Produtos;

namespace DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteCriacao.Factories
{
    public class QuartaSabadoFactory : IFactory
    {
        public QuartaSabadoFactory()
        {
            ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Quarta a Sábado");
            var dieta = new DietaQuartaSabado();
            var treino = new TreinoQuartaSabado();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }

}
