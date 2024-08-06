using DesignPatters.PatternsComportamental.Strategy.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsComportamental.Strategy
{
    public class CalculaTaxaServicos
    {
        public void Calcular(List<IServico> servicos)
        {
            foreach (var servico in servicos)
            {
                servico.CalcularServico();
                Console.WriteLine(new String('-', 40));
            }
        }
    }
}
