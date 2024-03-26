using DesignPatters.PatternsCriacao.FactoryMethod.Enums;

namespace DesignPatters.PatternsCriacao.FactoryMethod
{
    public class Client
    {
        public void ExecutarCriacaoProduto() 
        {
            var client = new SelectService();
            var continuar = true;

            while (continuar)
            {
                Console.WriteLine("Selecione o tipo de serviço:\n");
                Console.WriteLine("0 - Tradicional");
                Console.WriteLine("1 - Premium");
                Console.WriteLine("2 - Master");
                Console.WriteLine("3 - Cobertura");

                Console.WriteLine("Digite o numero do serviço que deseja cobrar");
                var tipoServico = Convert.ToInt32(Console.ReadLine());

                var servicoProduto = client.FabricarProduto((TipoService)tipoServico);

                Console.WriteLine("Deseja calcular outro serviço? (1 - Sim ou 2-Não): ");
                int resp = Convert.ToInt32(Console.ReadLine());
                continuar = resp == 1;
            }
        }
    }
}
