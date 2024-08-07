using DesignPatters.PatternsComportamental.ChainOfResponsability.AbstractModel;

namespace DesignPatters.PatternsComportamental.ChainOfResponsability.Receiver
{
    public class ServicoLavanderiaReceiver: CobrancaReceiver
    {
        public override Checkout ExecutarCobrancaServico(Checkout checkout)
        {
            Console.WriteLine("Realizando cobrança de taxa de serviço de lavanderia...");
            checkout.ValorTotal += (checkout.ValorTotal * 0.028);

            return base.ExecutarCobrancaServico(checkout);
        }
    }
}
