namespace DesignPatters.PatternsComportamental.Observer.Interfaces
{
    public interface ISujeito
    {
        List<IObservavel> Observavels { get; set; }
        void AddObservavel(IObservavel observavel);
        void RemoveObservavel(IObservavel observavel) ;
        void NoficarObservavel();
    }
}
