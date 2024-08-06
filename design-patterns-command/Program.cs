using DesignPatters.PatternsComportamental.Command.Botao;
using DesignPatters.PatternsComportamental.Command.Robo;
using DesignPatters.PatternsCriacao.FactoryMethod;
using DesignPatters.PatternsCriacao.PatternsAbstractFactory;
using ClientFactoryMethod = DesignPatters.PatternsCriacao.FactoryMethod.Client;
using ClientAbstractFactory = DesignPatters.PatternsCriacao.PatternsAbstractFactory.Client;
using ClientSingleton = DesignPatters.PatternsCriacao.Singleton.Client;
using ClientBuilder = DesignPatters.PatternsCriacao.Builder.Client;
using ClientFlyweight = DesignPatters.PatternsEstrutural.Flyweight.Client;
using ClientBridge = DesignPatters.PatternsEstrutural.Bridge.Client;
using ClientComposite = DesignPatters.PatternsEstrutural.Composite.Client;
using ClientDecorator = DesignPatters.PatternsEstrutural.Decorator.Client;
using ClientProxy = DesignPatters.PatternsEstrutural.Proxy.Client;
using ClientTemplate = DesignPatters.PatternsComportamental.TemplateMethod.Client;
using DesignPatters.PatternsCriacao.Prototype;
using DesignPatters.PatternsEstrutural.Adapter;
using DesignPatters.PatternsEstrutural.Bridge.Abstracao;
using DesignPatters.PatternsEstrutural.Bridge.Implementacao;
using System;
using DesignPatters.PatternsEstrutural.Facade;
using DesignPatters.PatternsComportamental.Interpreter.Jumanji;
using DesignPatters.PatternsComportamental.Observer;
using DesignPatters.PatternsComportamental.Visitor;
using DesignPatters.PatternsComportamental.Strategy;

class Program
{
    static void Main(string[] args)
    {
        // ExecutarPatternsCommand();
        // ExecutarPatternsFactoryMethod();
        // ExecutarPatternsFactoryMethod();
        // ExecutarPatternsSingleton();
        // ExecutarPatternsBuilders();
        // ExecutarPatternsAdapter();
        // ExecutarPatternsBridge();
        // ExecutarPatternsComposite();
        // ExecutarPatternsDecorator();
        // ExecutarPatternsFacade();
        // ExecutarPatternsProxy();
        // ExecutarPatternsProxy();
        //ExecutarPatternsInterpreter();
        // ExecutarPatternsObserver();
        //ExecutarPatternsVisitor();
        ExecutarPatternsStrategy();

    }

    private static void ExecutarPatternsStrategy()
    {
        var taxa = new RotinaTaxaServicos();
        taxa.ExecutarRotina();
    }
    private static void ExecutarPatternsVisitor()
    {
        var fiscal = new Fiscal();
        fiscal.CalcularImpostos();
    }

    private static void ExecutarPatternsObserver()
    {
        var sendEmail = new SendEmail();
        sendEmail.EnviarEmail();
    }


    private static void ExecutarPatternsInterpreter()
    {
        ApresentaPopup apresentaPopup = new ApresentaPopup();
        apresentaPopup.ApresentarHabilidadesPopup();
    }

    private static void ExecutarPatternsTemplate()
    {
        ClientTemplate template = new ClientTemplate();
        //template.ConsumirEndpointXml();

        template.ConsumirEndpointJson();
    }
    private static void ExecutarPatternsProxy()
    {
        ClientProxy proxy = new ClientProxy();
        proxy.TentativaConexaoClientVPN();
    }
    private static void ExecutarPatternsFacade()
    {
        FacadeManager facade = new FacadeManager();
        facade.ExecutarComplexidade();
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
    public static void ExecutarFlyweights()
    {
        ClientFlyweight client = new ClientFlyweight();
        client.ConsumirFlyweights();
    }

    public static void ExecutarPatternsBridge()
    {
        ClientBridge client;
        Random random;

        while (true)
        {
            client = new ClientBridge();
            random = new Random();

            if (random.Next(2) == 1)
            {
                client.Material = new CanetaEsferografica();
            }
            else
            {
                client.Material = new PincelMarcador();
            }


            if (random.Next(1, 3) == 1)
            {
                client.Material.CorImplementacao = new Azul();
            }
            else if (random.Next(1, 3) == 2)
            {
                client.Material.CorImplementacao = new Preto();
            }
            else
            {
                client.Material.CorImplementacao = new Vermelha();
            }

            client.ConsultarCanetasPinceisNoEstoque();

            Console.WriteLine("Pressione <Enter> para continuar ou qualquer tecla para finalizar...");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar != 13)
                break;

        }

    }
    public static void ExecutarPatternsComposite()
    {
        ClientComposite client = new ClientComposite();
        client.EfetuarCompra();
    }

    public static void ExecutarPatternsDecorator()
    {
        ClientDecorator client = new ClientDecorator();
        client.ConsumirServicos();
    }
}