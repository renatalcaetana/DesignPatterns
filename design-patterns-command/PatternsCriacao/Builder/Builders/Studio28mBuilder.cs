using DesignPatters.PatternsCriacao.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsCriacao.Builder.Builders
{
    public class Studio28mBuilder : StudioBuilder
    {
        public Studio28mBuilder()
        {
            studio = new Studio28m();
        }
        public override void DefinirValorStudio()
        {
            studio.DefinirValorStudio(20000.00M);
        }

        public override void EscolherFinancimento()
        {
            studio.EscolherFinancimento("FinalInvesti Imóveis");
        }

        public override void EscolherPiso()
        {
            studio.EscolherPiso("Piso Vinílico");
        }
    }
}
