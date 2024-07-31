using DesignPatters.PatternsComportamental.Interpreter.Jumanji.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFracos
{
    public class Forca : IPontoFraco
    {
        public void Interpretar(Contexto contexo)
        {
            contexo.Conteudo += "[+] - Força\n";
        }
    }
}
