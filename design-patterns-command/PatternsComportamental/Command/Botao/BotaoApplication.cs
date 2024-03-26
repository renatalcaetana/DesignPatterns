using DesignPatters.PatternsComportamental.Command.Botao.Concret;
using DesignPatters.PatternsComportamental.Command.Botao.Receptor;

namespace DesignPatters.PatternsComportamental.Command.Botao
{
    public class BotaoApplication
    {
        public void ExecutarComandosBotao()
        {
            var botao = new EditorCommand();
            var controle = new BotaoControle();

            ColarConcretComand colar = new ColarConcretComand(botao);
            controle.Comandos.Enqueue(colar);

            CopiarConcretComand copiar = new CopiarConcretComand(botao);
            controle.Comandos.Enqueue(copiar);

            SalvarConcretComand salvar = new SalvarConcretComand(botao);
            controle.Comandos.Enqueue(salvar);

            controle.ExecutarComandos();
            controle.DesfazerComandos(3);

            Console.ReadKey();
        }

    }
}
