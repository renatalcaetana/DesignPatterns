using DesignPatters.PatternsEstrutural.Decorator.Decorators;
using DesignPatters.PatternsEstrutural.Decorator.Interface;
using DesignPatters.PatternsEstrutural.Decorator.Service;

namespace DesignPatters.PatternsEstrutural.Decorator
{
    public class Client
    {
        public void ConsumirServicos()
        {
            IPet banhoTosa = new BanhoTosa("Banho e Tosa", 45.00);
            IPet AcessorioDecorator = new AcessorioDecorator(banhoTosa);
            IPet luxoSpaDecorator = new LuxoSpaDecorator(AcessorioDecorator);

            Console.WriteLine($"Resumo dos serviços petshop");
            Console.WriteLine(luxoSpaDecorator.GetNomeService());
            Console.WriteLine(luxoSpaDecorator.GetValorService());
        }
    }
}
