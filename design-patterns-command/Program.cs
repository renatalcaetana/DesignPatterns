using DesignPatters.PatternsComportamental.Command.Botao;
using DesignPatters.PatternsComportamental.Command.Robo;
using DesignPatters.PatternsCriacao.FactoryMethod;
using DesignPatters.PatternsCriacao.PatternsAbstractFactory;
using ClientFactoryMethod = DesignPatters.PatternsCriacao.FactoryMethod.Client;
using ClientAbstractFactory = DesignPatters.PatternsCriacao.PatternsAbstractFactory.Client;
using ClientSingleton = DesignPatters.PatternsCriacao.Singleton.Client;
using ClientBuilder = DesignPatters.PatternsCriacao.Builder.Client;
using DesignPatters.PatternsCriacao.Prototype;
using DesignPatters.PatternsEstrutural.Adapter;

class Program
{
    static void Main(string[] args)
    {
        // ExecutarPatternsCommand();
        // ExecutarPatternsFactoryMethod();
        // ExecutarPatternsFactoryMethod();
        // ExecutarPatternsSingleton();
        //ExecutarPatternsBuilders();
        ExecutarPatternsAdapter();


    }

    public static void ExecutarPatternsFactoryMethod()
    {
        ClientFactoryMethod client = new ClientFactoryMethod();
        client.ExecutarCriacaoProduto();
    }
    public static void ExecutarPatternsAbstractFactory()
    {
        var client = new ClientAbstractFactory();
        client.ConsultarRotinaAluno();
    }
    public static void ExecutarPatternsSingleton()
    {
        var client = new ClientSingleton();
        client.ConsumirDB();
    }
    public static void ExecutarPatternsCommand()
    {
        var Robo = new RoboApplication();
        Robo.ExecutarComandosRobo();

        var Botao = new BotaoApplication();
        Botao.ExecutarComandosBotao();
    }
    public static void ExecutarPatternsBuilders()
    {
        var client = new ClientBuilder();
        client.ConsumirDadosEtudios();
    }
    public static void ExecutarPatternsPrototype()
    {
        var client = new Cliente();
        client.ConsumirDadosEtudios();
    }
    public static void ExecutarPatternsAdapter()
    {
        var cloud = new cloudComputing();
        cloud.ProcessarContas("setembro");
    }
}