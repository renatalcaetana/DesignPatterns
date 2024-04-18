namespace DesignPatters.PatternsCriacao.Prototype
{
    public class Studio : StudioModel
    {
        private string _tipoStudio;
        private string _tipoFinancimento;
        private decimal _valorStudio;

        public Studio(string tipoStudio, string tipoFinancimento, decimal valorStudio)
        {
            _tipoStudio = tipoStudio;
            _tipoFinancimento = tipoFinancimento;
            _valorStudio = valorStudio;
        }

        public override StudioModel Clone()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string($"Studio clonado: {_tipoStudio}\nFinancimanto: {_tipoFinancimento}\nValor: {_valorStudio.ToString("C")}\n"));
            return this.MemberwiseClone() as StudioModel;
        }
    }
}
