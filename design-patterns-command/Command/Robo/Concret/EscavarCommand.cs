using DesignPatters.Command.Robo.Abstracao;
using DesignPatters.Command.Robo.Receptor;

namespace DesignPatters.Command.Robo.Concret
{
    //MoverCommand , RotacionarCommand e EscavarCommand - Representam a classe CommandConcreto que herda da classe RoboCommand e implementa os comandos desejados;
    public class EscavarCommand : RoboCommand
    {
        public bool ColherMaterial { get; set; }

        public EscavarCommand(RoboReceptor robo) : base(robo) { }

        public override void Executar()
        {
            _robo.Escavar(ColherMaterial);
        }

        public override void Desfazer()
        {
            _robo.Escavar(!ColherMaterial);
        }
    }
}
