using DesignPatters.PatternsComportamental.Interpreter.Jumanji.Intefaces;
using DesignPatters.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFortes;
using DesignPatters.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFracos;

namespace DesignPatters.PatternsComportamental.Interpreter.Jumanji
{
    public class Habilidades : IExpressao
    {
        private List<IPontoFraco> _pontosFracos;
        private List<IPontoForte> _pontosFortes;

        public Habilidades(List<IPontoFraco> pontosFracos, List<IPontoForte> pontosFortes)
        {
            this._pontosFracos = pontosFracos;
            this._pontosFortes = pontosFortes;
        }

        public void Interpretar(Contexto contexo)
        {
            Console.WriteLine($"\nPersonagem: {contexo.Personagem}");
            contexo.Conteudo += "Exibindo habilidades ...\n\nPontos Fortes:\n";

            foreach (var forte in _pontosFortes)
            {
                forte.Interpretar(contexo);
            }

            contexo.Conteudo += "\nPontos Fracos:\n";

            foreach (var fraco in _pontosFracos)
            {
                fraco.Interpretar(contexo);
            }

            Console.WriteLine(contexo.Conteudo);

        }
    }
}
