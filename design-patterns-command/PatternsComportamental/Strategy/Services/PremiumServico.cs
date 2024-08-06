using DesignPatters.PatternsComportamental.Strategy.Intefaces;
using DesignPatters.PatternsComportamental.Strategy.Model;

namespace DesignPatters.PatternsComportamental.Strategy.Services
{
    public class PremiumServico : IServico
    {
        private Orcamento _orcamento;

        public PremiumServico(Orcamento orcamento)
        {
            _orcamento = orcamento;
        }

        public void CalcularServico()
        {
            var porcentagem = _orcamento.ValorTotal * ((double)_orcamento.Porcentagem / 100);
            _orcamento.ValorTotal += porcentagem;


            if (_orcamento.CupomDesconto)
            {
                Console.WriteLine($"\nValor sem desconto: {_orcamento.ValorTotal.ToString("C")}");
                _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.02;

                Console.WriteLine($"Cupom de desconto de 2% para suite Premium.\n");
            }
          
            Console.WriteLine($"Tipo quarto: {_orcamento.Porcentagem}" +
                $"\nPorcentagem Serviço: {porcentagem.ToString("C")}" +
                $"\nQuantidade dias: {_orcamento.Quantidade}" +
                $"\nValor Dia: {_orcamento.ValorDiaria}" +
                $"\nValor Total: {_orcamento.ValorTotal}");
        }
    }
}
