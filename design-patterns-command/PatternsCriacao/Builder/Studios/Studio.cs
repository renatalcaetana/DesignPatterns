namespace DesignPatters.PatternsCriacao.Builder.Studios
{
    public abstract class Studio
    {
        public string TipoPiso { get; protected set; }
        public string TipoFinanciamento { get; protected set; }
        public decimal ValorStudio { get; protected set; }

        public abstract void EscolherPiso(string piso);
        public abstract void EscolherFinancimento(string financimento);
        public abstract void DefinirValorStudio(decimal valor);
    }
}
