using DesignPatters.PatternsComportamental.Command.Robo.Abstracao;
using DesignPatters.PatternsComportamental.Command.Robo.Receptor;

namespace DesignPatters.PatternsComportamental.Command.Robo.Concret
{
    public class MoverCommand : RoboCommand
    {
        //MoverCommand , RotacionarCommand e EscavarCommand - Representam a classe CommandConcreto que herda da classe RoboCommand e implementa os comandos desejados;
        public int ParaFrente { get; set; }
        public MoverCommand(RoboReceptor robo) : base(robo) { }

        public override void Executar()
        {
            _robo.Mover(ParaFrente);
        }

        public override void Desfazer()
        {
            _robo.Mover(-ParaFrente);
        }
    }
}
