using DesignPatters.PatternsComportamental.Visitor.Interfaces;
using DesignPatters.PatternsComportamental.Visitor.Produtos;
using DesignPatters.PatternsComportamental.Visitor.Visitors;

namespace DesignPatters.PatternsComportamental.Visitor
{
    public class Fiscal
    {
        public void CalcularImpostos()
        {
            CalcularProdutosPereciveis();

            Console.WriteLine(new string('-', 40));

            CalcularProdutosNaoPereciveis();
        }
        private static void CalcularProdutosPereciveis()
        {
            List<ProdutoPerecivel> produtoPerecivels = new List<ProdutoPerecivel>()
            {
                new ProdutoPerecivel("Arroz", 1000),
                new ProdutoPerecivel("Caixa de Leite", 2000)
            };

            Console.WriteLine("\nCalculando imposto produtos perecíveis:\n");

            foreach (var item in produtoPerecivels)
            {
                Console.WriteLine($"Produto: {item.Nome}\nPeso: {item.Peso}");

                foreach (var visitor in GetVisistors())
                {
                    visitor.CalcularImpostoProdutoPerecivel(item);
                }
                Console.WriteLine();
            }
        }
        private static void CalcularProdutosNaoPereciveis()
        {
            List<ProdutoNaoPerecivel> produtoNaoPerecivels = new List<ProdutoNaoPerecivel>()
            {
                new ProdutoNaoPerecivel("Antena Wifi", 500),
                new ProdutoNaoPerecivel("Perfume Francês", 1000)
            };

            Console.WriteLine("\nCalculando imposto produtos NÂO perecíveis:\n");

            foreach (var item in produtoNaoPerecivels)
            {
                Console.WriteLine($"Produto: {item.Nome}\nPeso: {item.Peso}");

                foreach (var visitor in GetVisistors())
                {
                    visitor.CalcularImpostoProdutoNaoPerecivel(item);
                }
                Console.WriteLine();
            }
        }

        private static List<IVisitor> GetVisistors() =>
            new List<IVisitor>()
            {
                new RioJaneiroVisitor(), new SaoPauloVisitor()
            };
    }
}
