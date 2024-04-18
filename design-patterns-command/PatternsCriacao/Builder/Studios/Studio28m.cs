namespace DesignPatters.PatternsCriacao.Builder.Studios
{
    public class Studio28m : Studio
    {
        public override void DefinirValorStudio(decimal valor)
        {
            ValorStudio = valor;
        }

        public override void EscolherFinancimento(string financimento)
        {
            TipoFinanciamento = financimento;
        }

        public override void EscolherPiso(string piso)
        {
           TipoPiso = piso;
        }
    }
}
