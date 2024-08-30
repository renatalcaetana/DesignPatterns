using DesignPatters.PatternsComportamental.State.Interface;

namespace DesignPatters.PatternsComportamental.State.Estados
{
    public class EstadoB : IEstado
    {
        public void Acao(Context context)
        {
            Console.WriteLine("Executando ações do estado B");
            context.Estado = new EstadoA();
        }
    }
}