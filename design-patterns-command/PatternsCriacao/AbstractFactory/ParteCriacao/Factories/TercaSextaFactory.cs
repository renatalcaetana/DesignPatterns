using DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteCriacao.Interfaces;
using DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteProduto.Produtos;

namespace DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteCriacao.Factories
{
    public class TercaSextaFactory : IFactory
    {
        public TercaSextaFactory()
        {
            ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Terça a Sexta");
            var dieta = new DietaTercaSexta();
            var treino = new TreinoQuartaSabado();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }

}
