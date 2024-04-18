using DesignPatters.PatternsCriacao.Builder.Builders;
using DesignPatters.PatternsCriacao.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsCriacao.Builder
{
    public class Client
    {
        public void ConsumirDadosEtudios()
        { 
            Director director = new Director();
            StudioBuilder studioBuilder;
            Studio studio;

            studioBuilder = new Studio24mBuilder();
            director.ConstruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "24m1");

            studioBuilder = new Studio26mBuilder();
            director.ConstruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "26m1");

            studioBuilder = new Studio28mBuilder();
            director.ConstruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "28m1");
        }

        private void ImprimirResultado(Studio studio, string nome)
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"[+] - Studio {nome}");
            Console.WriteLine("Valor:{0}\nPiso: {1}\nFinanciamento: {2}",
                studio.ValorStudio.ToString("c"),
                studio.TipoPiso,
                studio.TipoFinanciamento);
        }
    }
}
