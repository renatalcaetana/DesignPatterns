using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Facade.AmbienteComplexo
{
    public class ZonaNorte
    {
        public List<object> ExecutarRotinaVendasPerdidas(DateTime periodo)
        {
            Console.WriteLine("[!] - Executando complexidade rotina vendas perdidas região norte");

            return new List<object>();
        }
    }
}
