namespace DesignPatters.PatternsComportamental.Memento
{
    public class Originator
    {
        public string _estado;
        public string Estado
        {
            get
            {
                return _estado;
            }
            set
            {
                _estado = value;
                Console.WriteLine($"Estado atual do vídeo:{_estado}");
            }
        }
        public SnapShot CreateSnapshot()
        {
            return (new SnapShot(_estado)); 
        }

        public void Restore(SnapShot snapshot)
        {
            Console.WriteLine("Restaurando estado...");
            Estado = snapshot.GetState();
        }
    }
}
