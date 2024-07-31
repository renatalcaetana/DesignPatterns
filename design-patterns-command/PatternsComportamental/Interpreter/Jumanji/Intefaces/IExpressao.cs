using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsComportamental.Interpreter.Jumanji.Intefaces
{
    public interface IExpressao
    {
        void Interpretar(Contexto contexo);
    }
}
