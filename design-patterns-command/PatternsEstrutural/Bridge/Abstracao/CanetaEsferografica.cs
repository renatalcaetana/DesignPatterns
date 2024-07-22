using DesignPatters.PatternsEstrutural.Bridge.Abstracao.Interfaces;
using DesignPatters.PatternsEstrutural.Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Bridge.Abstracao
{
    public class CanetaEsferografica : IMaterial
    {
        public ICor CorImplementacao { get; set; }

        public string ConsultarNoEstoque()
        {
            return CorImplementacao.ConsultarQuantidadePorCor("Caneta Esferografica");
        }
    }
}
