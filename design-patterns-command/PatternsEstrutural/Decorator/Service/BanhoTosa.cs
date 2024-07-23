using DesignPatters.PatternsEstrutural.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Decorator.Service
{
    public class BanhoTosa : IPet
    {
        private string _nomeServico;
        private double _valorServico;

        public BanhoTosa(string nomeServico, double valorServico)
        {
            _nomeServico = nomeServico;
            _valorServico = valorServico;
        }

        public string GetNomeService()
        {
            return _nomeServico;
        }

        public double GetValorService()
        {
            return _valorServico;
        }
    }
}
