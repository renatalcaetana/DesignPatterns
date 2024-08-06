using DesignPatters.PatternsComportamental.Strategy.Intefaces;
using DesignPatters.PatternsComportamental.Strategy.Model;

namespace DesignPatters.PatternsComportamental.Strategy.Services
{
    public class CoberturaServico : IServico
    {
        private Orcamento _orcamento;

        public CoberturaServico(Orcamento orcamento)
        {
            _orcamento = orcamento;
        }

        public void CalcularServico()
        {
            var porcentagem = _orcamento.ValorTotal * ((double) _orcamento.Porcentagem / 100);
            _orcamento.ValorTotal += porcentagem;

            if (_orcamento.Quantidade > 60)
            {
                Console.WriteLine($"\nValor sem desconto: {_orcamento.ValorTotal.ToString("C")}");
                _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.03;

                Console.WriteLine($"Conta superior a 60 dias recebe cupom de 3% de desconto para cobertura.\n");
            }
            Console.WriteLine($"Tipo quarto: {_orcamento.Porcentagem}" +
                $"\nPorcentagem Serviço: {porcentagem.ToString("C")}" +
                $"\nQuantidade dias: {_orcamento.Quantidade}" +
                $"\nValor Dia: {_orcamento.ValorDiaria}" +
                $"\nValor Total: {_orcamento.ValorTotal}");

        }
    }
}
