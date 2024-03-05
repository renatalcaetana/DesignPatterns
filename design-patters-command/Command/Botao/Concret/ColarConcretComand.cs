using DesignPatters.Command.Botao.Abstracao;
using DesignPatters.Command.Botao.Receptor;

namespace design_patters_command.Command.Botao.Concret
{
    public class ColarConcretComand : BotaoComandAbstract
    {
        public ColarConcretComand(EditorCommand receptor) : base(receptor) { }
        public override void Desfazer()
        {
            _receptor.Apagar();
        }

        public override void Executar()
        {
            _receptor.Colar();
        }
    }
}
