using DesignPatters.PatternsEstrutural.Decorator.Interface;
using System.Diagnostics.CodeAnalysis;

namespace DesignPatters.PatternsEstrutural.Decorator.Decorators
{
    public abstract class PetDecorator : IPet
    {
        protected IPet _pet;
        protected PetDecorator(IPet pet)
        {
            _pet = pet;
        }

        public virtual string GetNomeService()
        {
            return _pet.GetNomeService();
        }

        public virtual double GetValorService()
        {
            return _pet.GetValorService();
        }
    }
}
