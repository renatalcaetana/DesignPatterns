namespace DesignPatters.PatternsComportamental.Memento
{
    public class SnapShot
    {
        private string _estado;

        public SnapShot(string estado)
        {
            _estado = estado;
        }
        public string GetState() 
        {
            return _estado;
        }
    }
}
