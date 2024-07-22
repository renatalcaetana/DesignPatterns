using DesignPatters.PatternsEstrutural.Bridge.Abstracao.Interfaces;
using DesignPatters.PatternsEstrutural.Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Bridge.Implementacao
{
    public class Preto: ICor
    {
        public string ConsultarQuantidadePorCor(string tipoAbstracao)
        {
            var random = new Random();
            var quantidade = random.Next(100, 500);

            return $"Existem {quantidade} para {tipoAbstracao} de cor preta estoque.";
        }
    }
}
