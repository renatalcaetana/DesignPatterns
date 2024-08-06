using DesignPatters.PatternsComportamental.Strategy.Intefaces;
using DesignPatters.PatternsComportamental.Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsComportamental.Strategy.Services
{
    public class TradicionalServico : IServico
    {
        private Orcamento _orcamento;

        public TradicionalServico(Orcamento orcamento)
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
                _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.01;

                Console.WriteLine($"Cupom de descconto de 1% para quarto tradicional.\n");
            }

            
            Console.WriteLine($"Tipo quarto: {_orcamento.Porcentagem}" +
                $"\nPorcentagem Serviço: {porcentagem.ToString("C")}" +
                $"\nQuantidade dias: {_orcamento.Quantidade}" +
                $"\nValor Dia: {_orcamento.ValorDiaria}" +
                $"\nValor Total: {_orcamento.ValorTotal}");
        }
    }
}
