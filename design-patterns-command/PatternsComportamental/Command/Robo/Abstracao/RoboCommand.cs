using DesignPatters.PatternsComportamental.Command.Robo.Receptor;

namespace DesignPatters.PatternsComportamental.Command.Robo.Abstracao
{
    //RoboCommand - Representa a classe abstrata Command onde definimos os método Executar() e Desfazer();
    public abstract class RoboCommand
    {
        protected RoboReceptor _robo;

        public RoboCommand(RoboReceptor robo)
        {
            _robo = robo;
        }

        public abstract void Executar();
        public abstract void Desfazer();
    }

}
