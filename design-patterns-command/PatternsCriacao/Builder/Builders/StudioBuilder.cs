using DesignPatters.PatternsCriacao.Builder.Studios;

namespace DesignPatters.PatternsCriacao.Builder.Builders
{
    public abstract class StudioBuilder
    {
        protected Studio studio;

        public Studio GetStudio() 
        { 
            return studio; 
        }

        public abstract void EscolherPiso();
        public abstract void EscolherFinancimento();
        public abstract void DefinirValorStudio();
    }
}
