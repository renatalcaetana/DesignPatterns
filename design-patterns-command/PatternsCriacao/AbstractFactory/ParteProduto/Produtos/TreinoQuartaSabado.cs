using DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteProduto.Interfaces;

namespace DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteProduto.Produtos
{
    public class TreinoQuartaSabado : ITreino
    {
        public TreinoQuartaSabado()
        {
            ObterTreino();
        }
        public void ObterTreino()
        {
            Console.WriteLine("Treino Quarta e Sábado...");
        }
    }
}
