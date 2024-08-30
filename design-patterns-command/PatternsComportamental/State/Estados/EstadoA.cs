using DesignPatters.PatternsComportamental.State.Interface;

namespace DesignPatters.PatternsComportamental.State.Estados
{
    public class EstadoA : IEstado
    {
        public void Acao(Context context)
        {
            Console.WriteLine("Executando ações do estado A");
            context.Estado = new EstadoB();
        }
    }
}
