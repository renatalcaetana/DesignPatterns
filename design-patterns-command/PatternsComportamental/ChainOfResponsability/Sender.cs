using DesignPatters.PatternsComportamental.ChainOfResponsability.Receiver;

namespace DesignPatters.PatternsComportamental.ChainOfResponsability
{
    public class Sender
    {
        public void RealizarCheckout()
        {
            Checkout checkout = new Checkout(1001, 20, 23.50);

            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"\nAntes: \nValor total checkout: {checkout.ValorTotal.ToString("C")}");

            var servicoLavanderia = new ServicoLavanderiaReceiver();
            var servicoQuarto = new ServicoQuartoReceiver();
            var servicoLimpeza = new ServicoLimpezaReceiver();

            servicoLavanderia.AddNext(servicoQuarto);
            servicoQuarto.AddNext(servicoLimpeza);

            servicoLavanderia.ExecutarCobrancaServico(checkout);

            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"\nDepois: \nValor total checkout: {checkout.ValorTotal.ToString("C")}");

        }
    }
}
