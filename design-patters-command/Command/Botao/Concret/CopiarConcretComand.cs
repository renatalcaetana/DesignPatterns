using DesignPatters.Command.Botao.Abstracao;
using DesignPatters.Command.Botao.Receptor;

namespace DesignPatters.Command.Botao.Concret
{
    public class CopiarConcretComand : BotaoComandAbstract
    {
        public CopiarConcretComand(EditorCommand receptor) : base(receptor) { }
        public override void Desfazer()
        {
            _receptor.Apagar();
        }

        public override void Executar()
        {
            _receptor.Copiar();
        }
    }
}
