using DesignPatters.PatternsCriacao.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsCriacao.Builder
{
    public class Director
    {
        public void ConstruirStudio(StudioBuilder builderBuilder)
        {
            builderBuilder.EscolherPiso();
            builderBuilder.DefinirValorStudio();
            builderBuilder.EscolherFinancimento();
        }

    }
}
