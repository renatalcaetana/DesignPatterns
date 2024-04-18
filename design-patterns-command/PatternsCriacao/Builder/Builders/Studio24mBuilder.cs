using DesignPatters.PatternsCriacao.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsCriacao.Builder.Builders
{
    public class Studio24mBuilder : StudioBuilder
    {
        public Studio24mBuilder()
        {
            studio = new Studio24m();   
        }
        public override void DefinirValorStudio()
        {
            studio.DefinirValorStudio(180000.00M);
        }

        public override void EscolherFinancimento()
        {
            studio.EscolherFinancimento("FinalMovelFinanciamentos");
        }

        public override void EscolherPiso()
        {
            studio.EscolherPiso("Cerâmica");
        }
    }
}
