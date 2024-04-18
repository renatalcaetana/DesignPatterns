namespace DesignPatters.PatternsCriacao.Prototype
{
    public class GerenciadorVendasStudio
    {
        private Dictionary<string, StudioModel> _studioModel = new Dictionary<string, StudioModel>();

        public StudioModel this[string key]
        {
            get { return _studioModel[key]; }
            set { _studioModel[key] = value;}
        }
    }
}
