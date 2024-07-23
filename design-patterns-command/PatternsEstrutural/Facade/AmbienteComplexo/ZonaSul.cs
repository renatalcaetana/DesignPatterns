using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Facade.AmbienteComplexo
{
    public class ZonaSul
    {
        public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo)
        {
            Console.WriteLine("[!] - Executando complexidade rotina vendas perdidas região sul");

            return new List<object>();
        }

    }
}
