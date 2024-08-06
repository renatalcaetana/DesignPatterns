using DesignPatters.PatternsComportamental.Visitor.Interfaces;
using DesignPatters.PatternsComportamental.Visitor.Produtos;

namespace DesignPatters.PatternsComportamental.Visitor.Visitors
{
    public class RioJaneiroVisitor : IVisitor
    {
        public double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel)
        {
            var imposto = (produtoNaoPerecivel.Peso / 100) + 5;

            Console.WriteLine($"Imposto Rio de Janeiro: {imposto}");

            return imposto;
        }

        public double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel)
        {
            var imposto = (produtoPerecivel.Peso / 100) + 10;

            Console.WriteLine($"Imposto Rio de Janeiro: {imposto}");

            return imposto;
        }
    }
}
