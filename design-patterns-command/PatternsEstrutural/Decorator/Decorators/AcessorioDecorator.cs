using DesignPatters.PatternsEstrutural.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsEstrutural.Decorator.Decorators
{
    public class AcessorioDecorator : PetDecorator
    {
        public AcessorioDecorator(IPet pet) : base(pet)
        {
        }

        public override double GetValorService()
        {
            return base.GetValorService() + 30.00;
        }

        public override string GetNomeService()
        {
            return base.GetNomeService() + "\n[+] Acessório";
        }
    }
}
