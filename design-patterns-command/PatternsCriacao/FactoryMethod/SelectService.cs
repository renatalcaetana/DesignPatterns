using DesignPatters.PatternsCriacao.FactoryMethod.Enums;
using DesignPatters.PatternsCriacao.FactoryMethod.Interfaces;
using DesignPatters.PatternsCriacao.FactoryMethod.Services;

namespace DesignPatters.PatternsCriacao.FactoryMethod
{
    public class SelectService : ServiceFactory
    {
        public override IService FabricarProduto(TipoService tipoService)
        {
            switch (tipoService)
            {
                case TipoService.tradicional:
                    return new TradicionalService();
              
                case TipoService.cobertura:
                    return new CoberturaService();
           
                case TipoService.premium:
                    return new PremiumService();
               
                case TipoService.master:
                    return new MasterService();
        
                default:
                    return null;
            }
        }
    }
}
