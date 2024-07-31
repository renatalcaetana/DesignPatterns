using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFortes
{
    public class Zoologia : IPontoForte
    {
        public void Interpretar(Contexto contexo)
        {
            contexo.Conteudo += "[+] - Expert em zoologia\n";
        }
    }
}
