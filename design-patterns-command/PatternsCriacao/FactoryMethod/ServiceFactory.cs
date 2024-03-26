using DesignPatters.PatternsCriacao.FactoryMethod.Enums;
using DesignPatters.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatters.PatternsCriacao.FactoryMethod
{
    public abstract class ServiceFactory
    {
        public abstract IService FabricarProduto(TipoService tipoServices);
    }
}
