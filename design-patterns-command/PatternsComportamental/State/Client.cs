using DesignPatters.PatternsComportamental.State.Estados;

namespace DesignPatters.PatternsComportamental.State
{
    public class Client
    {
        public void ExecutarContext()
        {
            Context context = new Context(new EstadoA());

            context.Trocar();
            context.Trocar();
        }

    }
}
