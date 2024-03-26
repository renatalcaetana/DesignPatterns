using DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteProduto.Interfaces;

namespace DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteProduto.Produtos
{
    public class TreinoSegundaQuinta : ITreino
    {
        public TreinoSegundaQuinta()
        {
            ObterTreino();
        }
        public void ObterTreino()
        {
            Console.WriteLine("Treino Segunda e Quinta feira...");
        }
    }
}
