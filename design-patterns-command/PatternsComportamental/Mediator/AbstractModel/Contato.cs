namespace DesignPatters.PatternsComportamental.Mediator.AbstractModel
{
    public abstract class Contato
    {
        protected Mediador Mediador;
        public Contato(Mediador mediador)
        {
            Mediador = mediador;
                
        }

    }
}