using DesignPatters.PatternsEstrutural.Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Adapter
{
    public class Adapter : IAdapter
    {
        BusinessLegado legado;
        public Adapter(BusinessLegado legado)
        {
            this.legado = legado;
        }
        public string ExecutarRotinaContasPagar(string mes)
        {
            return legado.ExecutarRotinaContasPagar(mes);
        }

        public string ExecutarRotinaContasReceber(string mes)
        {
            return legado.ExecutarRotinaContasPagar(mes);
        }
    }
}
