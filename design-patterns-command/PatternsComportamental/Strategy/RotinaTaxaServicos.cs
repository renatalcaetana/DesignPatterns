﻿using DesignPatters.PatternsComportamental.Strategy.Enum;
using DesignPatters.PatternsComportamental.Strategy.Intefaces;
using DesignPatters.PatternsComportamental.Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatters.PatternsComportamental.Strategy.Services;

namespace DesignPatters.PatternsComportamental.Strategy
{
    public class RotinaTaxaServicos
    {
        public void ExecutarRotina()
        {
            var cobertura01 = new Orcamento(01, 70, 30, PorcentagemServicos.Cobertura);
            var cobertura02 = new Orcamento(02, 70, 65, PorcentagemServicos.Cobertura);
            var master01 = new Orcamento(03, 50, 20, PorcentagemServicos.Master, true);
            var master02 = new Orcamento(04, 50, 62, PorcentagemServicos.Master, true);
            var master03 = new Orcamento(05, 50, 15, PorcentagemServicos.Master);
            var premium01 = new Orcamento(06, 40, 23, PorcentagemServicos.Premium, true);
            var premium02 = new Orcamento(07, 40, 23, PorcentagemServicos.Premium);
            var tradicional01 = new Orcamento(07, 30, 20, PorcentagemServicos.Tradicional);
            var tradicional02 = new Orcamento(08, 40, 32, PorcentagemServicos.Tradicional, true);

            var orcamentosServicos = new List<IServico>()
            {
                new CoberturaServico(cobertura01),
                new CoberturaServico(cobertura02),
                new MasterServico(master01),
                new MasterServico(master02),
                new MasterServico(master03),
                new PremiumServico(premium01),
                new PremiumServico(premium02),
                new TradicionalServico(tradicional01),
                new TradicionalServico(tradicional02)
            };
            var calcularTaxaServicos = new CalculaTaxaServicos();
            calcularTaxaServicos.Calcular(orcamentosServicos);

        }
    }
}
