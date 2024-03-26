using DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteProduto.Interfaces;

namespace DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteProduto.Produtos
{
    public class DietaTercaSexta : IDieta
    {
        public DietaTercaSexta()
        {
            ObterAlimentacao();
        }
        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta de terça e sexta feira...");
        }
    }
}
