using DesignPatters.PatternsEstrutural.Facade.AmbienteComplexo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Facade
{
    public class FacadeManager
    {
        public void ExecutarComplexidade()
        {
            ZonaNorte zonaNorte = new ZonaNorte();
            ZonaSul zonaSul = new ZonaSul();
            CloudComputing cloud = new CloudComputing();

            var sul = zonaSul.ExecutaRotinaVendasPerdidas(DateTime.Now);
            var norte = zonaNorte.ExecutarRotinaVendasPerdidas(DateTime.Now);
        }
    }
}
