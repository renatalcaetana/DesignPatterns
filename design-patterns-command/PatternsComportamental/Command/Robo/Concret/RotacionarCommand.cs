using DesignPatters.PatternsComportamental.Command.Robo.Abstracao;
using DesignPatters.PatternsComportamental.Command.Robo.Receptor;

namespace DesignPatters.PatternsComportamental.Command.Robo.Concret
{
    //MoverCommand , RotacionarCommand e EscavarCommand - Representam a classe CommandConcreto que herda da classe RoboCommand e implementa os comandos desejados;
    class RotacionarCommand : RoboCommand
    {
        public double rotacionarParaEsquerda { get; set; }
        public RotacionarCommand(RoboReceptor robo) : base(robo) { }

        public override void Executar()
        {
            _robo.RotacionarParaEsquerda(rotacionarParaEsquerda);
        }

        public override void Desfazer()
        {
            _robo.RotacionarParaEsquerda(-rotacionarParaEsquerda);
        }
    }
}
