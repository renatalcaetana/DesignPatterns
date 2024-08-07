using DesignPatters.PatternsComportamental.ChainOfResponsability.AbstractModel;

namespace DesignPatters.PatternsComportamental.ChainOfResponsability.Receiver
{
    public class ServicoLimpezaReceiver : CobrancaReceiver
    {
        public override Checkout ExecutarCobrancaServico(Checkout checkout)
        {
            Console.WriteLine("Realizando cobrança de taxa de serviço de limpeza...");
            checkout.ValorTotal += (checkout.ValorTotal * 0.025);

            return base.ExecutarCobrancaServico(checkout);
        }
    }
}
