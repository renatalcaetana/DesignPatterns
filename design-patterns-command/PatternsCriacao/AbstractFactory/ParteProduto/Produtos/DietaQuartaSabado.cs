using DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteProduto.Interfaces;

namespace DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteProduto.Produtos
{
    public class DietaQuartaSabado : IDieta
    {
        public DietaQuartaSabado()
        {
            ObterAlimentacao();
        }
        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta de quarta e sábado...");
        }
    }
}
