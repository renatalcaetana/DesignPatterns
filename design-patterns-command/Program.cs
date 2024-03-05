using DesignPatters.Command.Botao;
using DesignPatters.Command.Robo;
using DesignPatters.Command.Robo.Concret;
using DesignPatters.Command.Robo.Receptor;

class Program
{
    static void Main(string[] args)
    {
         var Robo = new RoboApplication();
        Robo.ExecutarComandosRobo();

        var Botao = new BotaoApplication();
        Botao.ExecutarComandosBotao();

    }
}