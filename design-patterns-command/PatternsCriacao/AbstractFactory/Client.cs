using DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteCriacao.Factories;
using DesignPatters.PatternsCriacao.PatternsAbstractFactory.ParteCriacao.Interfaces;

namespace DesignPatters.PatternsCriacao.PatternsAbstractFactory
{
    public class Client
    {
        public void ConsultarRotinaAluno()
        {
            var continuar = true;

            while (continuar)
            {
                IFactory factory = null;

                Console.WriteLine("Selecione a rotina desejada:");
                Console.WriteLine("1 - Segunda e Quinta");
                Console.WriteLine("2 - Terça e Sexta");
                Console.WriteLine("3 - Quarta e Sábado");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        factory = new SegundaQuintaFactory();
                        break;
                    case "2":
                        factory = new TercaSextaFactory();
                        break;
                    case "3":
                        factory = new QuartaSabadoFactory();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Deseja ver outra rotina? (1-Sim ou 2-Não)");
                var resp = Convert.ToInt32(Console.ReadLine());
                continuar = resp == 1;
            }
        }

    }
}
