using DesignPatters.PatternsComportamental.Command.Botao.Abstracao;

namespace DesignPatters.PatternsComportamental.Command.Botao
{
    class BotaoControle
    {
        public Queue<BotaoComandAbstract> Comandos;
        private Stack<BotaoComandAbstract> _desfazerPilha;

        public BotaoControle()
        {
            Comandos = new Queue<BotaoComandAbstract>();
            _desfazerPilha = new Stack<BotaoComandAbstract>();
        }

        public void ExecutarComandos()
        {
            Console.WriteLine("EXECUTANDO COMANDO(S).");

            while (Comandos.Count > 0)
            {
                BotaoComandAbstract comando = Comandos.Dequeue();
                comando.Executar();
                _desfazerPilha.Push(comando);
            }
        }

        public void DesfazerComandos(int numComandosDesfazer)
        {
            Console.WriteLine("DESFAZENDO {0} COMANDO(S).", numComandosDesfazer);

            while (numComandosDesfazer > 0 && _desfazerPilha.Count > 0)
            {
                BotaoComandAbstract comand = _desfazerPilha.Pop();
                comand.Desfazer();
                numComandosDesfazer--;
            }
        }
    }
}
