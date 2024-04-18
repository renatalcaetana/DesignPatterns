using DesignPatters.PatternsCriacao.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsCriacao.Builder.Builders
{
    public class Studio26mBuilder : StudioBuilder
    {
        public Studio26mBuilder()
        {
            studio = new Studio26m();
        }
        public override void DefinirValorStudio()
        {
            studio.DefinirValorStudio(190000.00M);
        }

        public override void EscolherFinancimento()
        {
            studio.EscolherFinancimento("Invest fácil");
        }

        public override void EscolherPiso()
        {
            studio.EscolherPiso("Porcelanato");
        }
    }
}
