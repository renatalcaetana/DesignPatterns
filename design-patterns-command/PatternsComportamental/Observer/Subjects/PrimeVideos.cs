using DesignPatters.PatternsComportamental.Observer.Interfaces;

namespace DesignPatters.PatternsComportamental.Observer.Subjects
{
    public class PrimeVideos : ISujeito
    {
        public List<IObservavel> Observavels { get; set; }

        public PrimeVideos()
        {
            Observavels = new List<IObservavel>();
        }

        public void AddObservavel(IObservavel observavel)
        {
            Observavels.Add(observavel);
        }

        public void NoficarObservavel()
        {
            foreach (var observavel in Observavels)
            {
                observavel.Update();
                Console.WriteLine(new String('-', 50));
            }
        }

        public void RemoveObservavel(IObservavel observavel)
        {
            Observavels.Remove(observavel);
        }
    }
}
