using DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteProduto.Interfaces;

namespace DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteProduto.Produtos
{
    public class TreinoTercaSexta : ITreino
    {
        public TreinoTercaSexta()
        {
            ObterTreino();
        }
        public void ObterTreino()
        {
            Console.WriteLine("Treino Terça e Sexta Feira...");
        }
    }
}
