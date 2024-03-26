using DesignPatters.PatternsComportamental.Command.Robo.Concret;
using DesignPatters.PatternsComportamental.Command.Robo.Receptor;

namespace DesignPatters.PatternsComportamental.Command.Robo
{
    public class RoboApplication
    {
        // A classe da aplicação define as relações de objeto. Ela age
        // como uma remetente: quando alguma coisa precisa ser feita,
        // ela cria um objeto comando e executa ele.
        public void ExecutarComandosRobo()
        {
            var robo = new RoboReceptor();
            var controle = new RoboControle();

            MoverCommand mover = new MoverCommand(robo);
            mover.ParaFrente = 1000;
            controle.Comandos.Enqueue(mover);

            RotacionarCommand rotacionar = new RotacionarCommand(robo);
            rotacionar.rotacionarParaEsquerda = 45;
            controle.Comandos.Enqueue(rotacionar);

            EscavarCommand escavar = new EscavarCommand(robo);
            escavar.ColherMaterial = true;
            controle.Comandos.Enqueue(escavar);

            controle.ExecutarComandos();
            controle.DesfazerComandos(3);

            Console.ReadKey();
        }

    }
}
