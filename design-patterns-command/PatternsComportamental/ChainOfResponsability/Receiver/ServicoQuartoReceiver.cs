using DesignPatters.PatternsComportamental.ChainOfResponsability.AbstractModel;

namespace DesignPatters.PatternsComportamental.ChainOfResponsability.Receiver
{
    public class ServicoQuartoReceiver : CobrancaReceiver
    {
        public override Checkout ExecutarCobrancaServico(Checkout checkout)
        {
            Console.WriteLine("Realizando cobrança de taxa de serviço de quarto...");
            checkout.ValorTotal += (checkout.ValorTotal * 0.03);

            return base.ExecutarCobrancaServico(checkout);
        }
    }
}

