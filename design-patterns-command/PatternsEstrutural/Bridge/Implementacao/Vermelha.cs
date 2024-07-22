using DesignPatters.PatternsEstrutural.Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Bridge.Implementacao
{
    public class Vermelha : ICor
    {
        public string ConsultarQuantidadePorCor(string tipoAbstracao)
        {
            var random = new Random();
            var quantidade = random.Next(100, 500);

            return $"Existem {quantidade} para {tipoAbstracao} de cor vermelha no estoque.";
        }
    }
}
