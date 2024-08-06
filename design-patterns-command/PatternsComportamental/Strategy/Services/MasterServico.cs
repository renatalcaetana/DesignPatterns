using DesignPatters.PatternsComportamental.Strategy.Intefaces;
using DesignPatters.PatternsComportamental.Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsComportamental.Strategy.Services
{
    public class MasterServico : IServico
    {
        private Orcamento _orcamento;

        public MasterServico(Orcamento orcamento)
        {
            _orcamento = orcamento;
        }

        public void CalcularServico()
        {
            var porcentagem = _orcamento.ValorTotal * ((double)_orcamento.Porcentagem / 100);
            _orcamento.ValorTotal += porcentagem;

            if (_orcamento.CupomDesconto && _orcamento.Quantidade > 60)
            {
                Console.WriteLine($"\nValor sem desconto: {_orcamento.ValorTotal.ToString("C")}");
                _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.03;

                Console.WriteLine($"Conta superior a 60 dias e cupom de desconto recebe 3% para suite master.\n");
            }

            else
            {
                if (_orcamento.CupomDesconto)
                {
                    Console.WriteLine($"\nValor sem desconto: {_orcamento.ValorTotal.ToString("C")}");
                    _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.02;

                    Console.WriteLine($"Cupom de desconto de 2% para suite master.\n");
                }
            }
            

            Console.WriteLine($"Tipo quarto: {_orcamento.Porcentagem}" +
                $"\nPorcentagem Serviço: {porcentagem.ToString("C")}" +
                $"\nQuantidade dias: {_orcamento.Quantidade}" +
                $"\nValor Dia: {_orcamento.ValorDiaria}" +
                $"\nValor Total: {_orcamento.ValorTotal}");
        }
    }
}
