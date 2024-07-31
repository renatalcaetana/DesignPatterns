using DesignPatters.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFortes;
using DesignPatters.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFracos;

namespace DesignPatters.PatternsComportamental.Interpreter.Jumanji
{
    public class ApresentaPopup
    {
        public void ApresentarHabilidadesPopup()
        {
            List<IPontoForte> pontoFortes = new List<IPontoForte>()
            {
                new Armeiro(), new Zoologia()
            };

            List<IPontoFraco> pontoFracos = new List<IPontoFraco>()
            {
                new Forca(), new Bolo(), new Velocidade()
            };

            var mooseFinbar = new Contexto("Moose Finbar");
            Habilidades habilidades = new Habilidades(pontoFracos, pontoFortes);
            habilidades.Interpretar(mooseFinbar);

        }
    }
}
